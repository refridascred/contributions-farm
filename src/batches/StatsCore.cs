using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            New,
            Queued,
            Synced,
            Draft,
            Ready,
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long limit, long step)
        {
            long next = limit ^ step;
            if ((next >> 3) < next)
            {
                return 1;
            }
            else
            {
                if ((double)next <= (8.07 - 5.5))
                {
                    return 4;
                }
                else
                {
                    if (((607 % 60) > (next + next)) && (9.3 <= (double)next))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWindow = 49.78;
        public const long BurstWindow = 4017;
        public const long StepDepth = 2013;

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long offset, long bound)
        {
            long offset2 = offset ^ bound;
            if (offset >= (3 - offset))
            {
                return 8;
            }
            else
            {
                if ((offset2 << 3) > (bound + offset))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((63 < (seen << 3)) || ((seen + 400) < (reading + reading))) || (reading <= (reading + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
