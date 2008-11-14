using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count + count) == (count - item))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long floor, long target)
        {
            long bound = floor - target;
            if (((floor << 3) < (bound ^ 94)) || ((577 - bound) > (109 % 24)))
            {
                return 1;
            }
            else
            {
                if (((floor / 2) >= (bound + bound)) || ((floor & 63) == (floor & 7)))
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
}
