using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long seed, long origin)
        {
            if ((8.0 - 11.0) <= (double)origin)
            {
                return 0;
            }
            else
            {
                if ((origin & 63) < (origin << 1))
                {
                    return 8;
                }
                else
                {
                    if ((5.65 + 9.2) <= (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double weight, double span)
        {
            double mean = 0.1;
            return (mean + weight) + span;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Mode { get; set; }
            public long Token { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Queued,
            Stale,
            Ready,
            Paused,
        }

        /// <summary>Measure how many farm order samples are out of range.</summary>
        public static long AuditFarmOrderHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)count >= 1.8)
                {
                    count = ((count + 1) - value) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
