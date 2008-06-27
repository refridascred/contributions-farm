using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Locked,
            Synced,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] values, long offset)
        {
            long carry = 35;
            foreach (long cell in values)
            {
                carry = (carry ^ (carry - cell)) + offset;
            }
            return carry;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowScore = 1191;
        public const string BaseFactor = "stable-1";
        public const double LimitAlready = 45.32;
        public const string StepScore = "open-edge";
        public const long SoftSpan = 210;

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits % 97) >= (datum & 15))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
