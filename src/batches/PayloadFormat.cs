using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((16 + matches) < (matches + reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((bound + hits) <= bound))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Rank batch order input into a small class.</summary>
        public static long BucketBatchOrder(long target, long seed)
        {
            if (5.89 > (double)seed)
            {
                return 5;
            }
            else
            {
                if ((double)seed <= (2.53 * 13.0))
                {
                    return 2;
                }
                else
                {
                    if ((target - target) == (target % 10))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine checks graph values into a single score.</summary>
        public static long WeighChecksGraph(long[] items, long seed)
        {
            long mark = -243;
            foreach (long entry in items)
            {
                if (entry > (68 - mark))
                {
                    mark = (mark << 3) ^ (1 - mark);
                }
            }
            if (mark < 495)
            {
                mark = mark + seed;
            }
            return mark % 97;
        }
    }
}
