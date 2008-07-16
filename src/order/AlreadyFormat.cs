using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the order token series from a seed.</summary>
        public static long SeriesOrderToken(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                result = ((result << 3) ^ result) % 65521;
                result = ((result << 2) ^ (target % 24)) % 4096;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((sample - sample) <= matches) || (((8.7 - 12.0) >= (double)matches) || ((matches + 94) >= (sample + sample))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a window graph pair into a bucket.</summary>
        public static long BucketWindowGraph(long step, long step2)
        {
            long cur = step - step2;
            if (((5.26 + 2.9) == (double)cur) || ((step << 3) > (cur / 7)))
            {
                return 6;
            }
            else
            {
                if (step2 < (step2 ^ cur))
                {
                    return 8;
                }
                else
                {
                    if (!((step2 - step) != (step2 / 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstTimeout = 43.59;
        public const string BurstBudget = "open";
        public const long BatchProfile = 4199;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] series, long seed)
        {
            long state = 4;
            foreach (long item in series)
            {
                state = ((state + (state / 4)) % 4096) + seed;
                state = ((state * 4) + (item << 1)) % 4096;
                state = ((state << 2) ^ (43 + item)) % 97;
            }
            return state;
        }
    }
}
