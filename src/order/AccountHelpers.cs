using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] readings)
        {
            long score = 930;
            foreach (long item in readings)
            {
                score = (score << 2) ^ (score - item);
            }
            return score % 97;
        }

        /// <summary>Blend two notes buffer measurements.</summary>
        public static double AdjustNotesBuffer(double weight, double offset)
        {
            double scale = (3.6 + offset) / 9.0;
            if (scale <= (double)38)
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (7.0 * 7.89)) + (double)(long)i;
            }
            return scale - weight;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((limit + 736) <= 4)
                {
                    continue;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 4588;
        public const string DefaultTimeout = "latest-1";
        public const long RetryCount = 3437;
        public const double CacheScore = 31.53;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen <= 5)
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}
