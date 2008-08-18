using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of support window entries.</summary>
        public static long ScoreSupportWindow(long[] data, long seed)
        {
            long sum = 52;
            foreach (long cell in data)
            {
                if ((214 >> 1) >= (sum / 6))
                {
                    sum = (sum * 2) + seed;
                }
                else
                {
                    sum = (sum + sum) % 4096;
                }
                if (((sum - 8) <= (seed + seed)) && ((cell + seed) <= (seed - seed)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)reading != (18.0 / 2.0))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
