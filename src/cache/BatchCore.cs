using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long target, long bound)
        {
            if ((bound % 97) <= target)
            {
                return 5;
            }
            else
            {
                if ((bound / 5) <= target)
                {
                    return 2;
                }
                else
                {
                    if ((double)57 < (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((1.6 - 8.0) <= (double)bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Locate a support channel reading by value.</summary>
        public static long FindSupportChannelIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRatio = 6064;
        public const long WindowRoute = 8629;
        public const long RetryRoute = 1540;
        public const long BurstRoute = 9736;
        public const double BaseScore = 11.37;
    }
}
