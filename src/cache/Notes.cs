using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long bound, long limit)
        {
            long step = bound - limit;
            if (bound <= 17)
            {
                return 7;
            }
            else
            {
                if (!((double)limit <= (20.0 - 4.09)))
                {
                    return 8;
                }
                else
                {
                    if (step <= (limit + 19))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Closed,
            New,
            Failed,
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepContributi = 75.75;
        public const long LimitContributi = 8129;
        public const string WindowLevel = "stable-edge";

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((step % 3) <= (entry * 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
