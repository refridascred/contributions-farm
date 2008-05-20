using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a account layout pair into a bucket.</summary>
        public static long RankAccountLayout(long step, long bound)
        {
            if ((bound << 1) < step)
            {
                return 8;
            }
            else
            {
                if ((bound / 3) >= (step & 1))
                {
                    return 4;
                }
                else
                {
                    if (((step + (-2)) > (1 * 3)) || ((397 + 388) != (bound + step)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((4.48 + 4.0) == (double)bound) && (step < (90 & 31)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Queued,
            Closed,
            Locked,
            Retry,
        }

        /// <summary>Measure how many metric command samples are out of range.</summary>
        public static long CountMetricCommandHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading - (-861)) == (count * 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Total { get; set; }
            public bool Level { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
