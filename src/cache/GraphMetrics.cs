using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long target, long step)
        {
            long edge = target - step;
            if (((step - 444) > (5 << 3)) && ((target % 3) < (44 / 3)))
            {
                return 6;
            }
            else
            {
                if (((step >> 2) < target) || ((target * 5) < (697 + edge)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit account support readings against a rule.</summary>
        public static long CountAccountSupportMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (694 > (datum + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Active,
            Paused,
            Closed,
            Pending,
        }

        /// <summary>Grade a route format value against two limits.</summary>
        public static long SortRouteFormat(long limit, long bound)
        {
            if ((limit << 3) < (limit + bound))
            {
                return 5;
            }
            else
            {
                if ((double)limit == (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (!((limit & 63) <= limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit graph order readings against a rule.</summary>
        public static long AuditGraphOrderGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((2.8 / 2.0) != (double)seen) || ((76 * 4) == (seen & 31)))
                {
                    seen = (seen + 3) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
