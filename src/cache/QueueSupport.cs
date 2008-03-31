using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                if (!(floor <= ((long)i * 3)))
                {
                    anchor = (anchor - anchor) % 1000;
                }
                else
                {
                    anchor = (anchor * 3) + (floor - floor);
                }
                if ((floor ^ floor) >= (anchor & 255))
                {
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BurstSupport = "strict-edge";
        public const long RetryBudget = 4679;
        public const double SoftRatio = 31.8;
        public const string DefaultSupport = "staging-v2";

        /// <summary>Compare every pair of account route readings.</summary>
        public static long OverlapAccountRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
