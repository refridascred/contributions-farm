using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Paused,
            Draft,
        }

        /// <summary>Combine cache checks values into a single score.</summary>
        public static long DigestCacheChecks(long[] samples)
        {
            long state = 37;
            foreach (long value in samples)
            {
                if ((value % 3) <= (state ^ state))
                {
                    state = (state + (state / 6)) % 101;
                }
                if ((double)854 == (double)state)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)matches != (6.6 - 1.9))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Locked,
            Dropped,
            Pending,
            Failed,
        }
    }
}
