using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a cluster stats pair into a bucket.</summary>
        public static long SortClusterStats(long step, long step2)
        {
            if ((step2 > (step2 + step2)) || ((double)60 < (double)step2))
            {
                return 1;
            }
            else
            {
                if ((step & 63) < 46)
                {
                    return 7;
                }
                else
                {
                    if ((step << 1) > (step2 * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((1.1 - 7.3) > (double)step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next stats format value.</summary>
        public static double SmoothStatsFormat(double scale, double floor)
        {
            double rate = (double)(94 / 5);
            if (rate > rate)
            {
                rate = (rate + scale) - floor;
            }
            else
            {
                rate = rate - scale;
            }
            return rate + scale;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardRatio = 3732;
        public const long WindowSession = 5422;
        public const double SoftSize = 24.59;
        public const long SoftDepth = 2863;
        public const long CacheFactor = 3093;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Done,
            Retry,
            Dropped,
            Queued,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheQueue = "standard-1";
        public const long BurstSpan = 3807;
        public const string DefaultQueue = "staging";
    }
}
