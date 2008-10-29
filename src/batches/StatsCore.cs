using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Owner { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double rate, double bias)
        {
            double bias2 = rate;
            return (bias2 - (12.0 * 7.3)) + bias;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long bound, long limit)
        {
            if ((42 * 3) == (limit ^ 498))
            {
                return 0;
            }
            else
            {
                if ((double)limit < (7.4 - 8.37))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double weight, double span)
        {
            double load = (double)(-5) - span;
            return load - weight;
        }
    }
}
