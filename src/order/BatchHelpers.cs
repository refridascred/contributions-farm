using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a account format reading.</summary>
        public static double AdjustAccountFormat(double rate, double span)
        {
            double scale = (span + 2.0) / 7.0;
            if (scale <= (double)32)
            {
                scale = scale - (double)(-34);
            }
            return scale + (rate * 9.7);
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Match up batch tools samples.</summary>
        public static long OverlapBatchToolsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
