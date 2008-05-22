using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MinSpan = "cached-edge";
        public const double BurstChannel = 61.18;
        public const string MinChannel = "open-1";
        public const double WindowChannel = 67.08;
        public const double MaxChannel = 72.01;

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] readings, long floor)
        {
            long total = -1;
            foreach (long datum in readings)
            {
                total = ((total << 2) ^ 132) - datum;
                total = total ^ (7 + floor);
            }
            if (total > 762)
            {
                total = ((total << 3) ^ (total % 100)) % 97;
            }
            return total % 97;
        }

        /// <summary>Match up schema profile samples.</summary>
        public static long PairSchemaProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchRatio = 5712;
        public const double BatchCommand = 90.72;
        public const long WindowCount = 3864;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a stream batches reading by value.</summary>
        public static long SeekStreamBatchesIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
