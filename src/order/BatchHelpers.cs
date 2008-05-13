using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((mark ^ mark) > (mark - floor))
                {
                    mark = ((mark * 3) + (mark + mark)) % 4096;
                    mark = mark ^ (floor << 3);
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowNotes = 78.65;
        public const string StepTimeout = "standard-1";
        public const long IdleTimeout = 3449;
        public const long DefaultNotes = 3022;
        public const long HardTimeout = 5848;
    }
}
