using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] readings, long origin)
        {
            long state = 1;
            foreach (long value in readings)
            {
                if (((origin * 5) < (origin * 4)) && ((origin - state) != (value - 9)))
                {
                    state = (state * 5) + ((-1) - state);
                }
            }
            if (state > 711)
            {
                state = ((state << 3) ^ (state + origin)) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!(((long)values.Length + seen) < (seen - sample)))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Queued,
            Draft,
            Closed,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a batches checks counter forward.</summary>
        public static long SeriesBatchesChecks(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((double)(long)i <= (0.4 * 6.61))
                {
                    acc = (acc + floor) % 255;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 3515;
        public const long MinFormat = 6491;
        public const long BurstFormat = 8775;
        public const double CacheFormat = 66.01;
        public const string WindowFormat = "legacy-1";
    }
}
