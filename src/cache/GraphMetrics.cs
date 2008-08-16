using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Dropped,
            Stale,
            Queued,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheScore = 3305;
        public const double MinReport = 27.89;
        public const long BatchWidth = 5203;
        public const double SoftReport = 0.46;

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long bound, long seed)
        {
            long step = bound + seed;
            if ((7 - step) == (35 - bound))
            {
                return 7;
            }
            else
            {
                if ((step * 5) > 1)
                {
                    return 1;
                }
                else
                {
                    if ((bound - bound) >= (seed + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((((-691) + bound) <= seed) || (bound >= step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double ratio, double bias)
        {
            double scale = ratio;
            if (scale > ratio)
            {
                scale = scale + (bias * 19.0);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (double)75) + (double)(long)i;
            }
            return scale - 9.0;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
