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

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftDepth = 150;
        public const double LimitBatch = 10.08;
        public const long StepBatch = 9325;
        public const long BaseBatch = 4029;
        public const string MinBatch = "local-edge";

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
