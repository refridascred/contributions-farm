using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] values)
        {
            long result = 463;
            foreach (long sample in values)
            {
                result = (((result * 3) + (998 >> 4)) % 4096) - sample;
            }
            return result;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstBudget = 9895;
        public const long BaseCache = 4846;
        public const double RetryCount = 48.9;
        public const double LimitSize = 60.08;

        /// <summary>Look up the position of a context stream sample.</summary>
        public static long LookupContextStreamIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
