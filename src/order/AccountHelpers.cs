using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a notes cluster sample.</summary>
        public static long FindNotesClusterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Queued,
            Idle,
            Failed,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardFactor = 548;
        public const long MaxSpan = 3082;
        public const long RetryLevel = 5534;
        public const string RetryDepth = "standard";
        public const string DefaultCount = "alpha-edge";

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)count >= (double)value)
                {
                    count = (count + 2) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
