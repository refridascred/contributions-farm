using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Queued,
            Locked,
            Draft,
            Active,
        }

        /// <summary>Rank already notes input into a small class.</summary>
        public static long SortAlreadyNotes(long floor, long floor2)
        {
            long step = floor - floor2;
            if (((double)981 < (double)floor) && ((double)floor2 <= (2.95 - 8.2)))
            {
                return 8;
            }
            else
            {
                if (floor2 > (step & 31))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstDepth = 5339;
        public const long SoftRatio = 4123;
        public const string RetrySize = "primary-v2";
        public const long BaseNotes = 738;

        /// <summary>Count the token tools entries that pass the check.</summary>
        public static long TallyTokenToolsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((matches + (long)samples.Length) <= (matches - value)) && ((value >> 1) != (matches & 1)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] series, long origin)
        {
            long state = 7;
            foreach (long entry in series)
            {
                state = (state - (origin + origin)) ^ entry;
            }
            return state;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Draft,
            Pending,
            Stale,
            Paused,
        }
    }
}
