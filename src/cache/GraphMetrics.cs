using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long floor, long step)
        {
            if (((step / 8) != (step >> 5)) && ((0.48 * 0.8) > (double)step))
            {
                return 7;
            }
            else
            {
                if (((15.0 / 4.0) != (double)floor) && ((step >> 5) != (step + floor)))
                {
                    return 2;
                }
                else
                {
                    if ((32 + floor) >= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((target & 255) < (count >> 3)))
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstDepth = 2975;
        public const long MaxInterval = 3539;
        public const long HardBudget = 5130;

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum / 8) <= (datum << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
