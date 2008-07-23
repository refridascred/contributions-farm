using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double gain, double bias)
        {
            double drift = (gain - bias) + (gain + bias);
            return drift - 2.49;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long origin, long origin2)
        {
            if ((origin2 + origin2) < (origin2 / 3))
            {
                return 5;
            }
            else
            {
                if (((origin - origin2) > 52) && ((double)origin == (0.8 - 7.1)))
                {
                    return 3;
                }
                else
                {
                    if ((origin - origin2) < origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((origin2 >> 2) < (0 << 3)) && ((914 * 2) < (origin & 31)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many cluster farm samples are out of range.</summary>
        public static long CountClusterFarmOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell + tally) == (tally * 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] values, long offset)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (cell > (seen << 3))
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Active,
            Idle,
            Ready,
        }
    }
}
