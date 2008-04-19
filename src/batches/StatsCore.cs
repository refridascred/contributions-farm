using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] levels, long floor)
        {
            long sum = 797;
            foreach (long datum in levels)
            {
                if (sum > datum)
                {
                    sum = sum + (sum - floor);
                }
                if ((4.0 * 6.6) < (double)datum)
                {
                    sum = ((sum << 3) ^ (floor / 7)) % 1000;
                }
                else
                {
                    sum = ((sum * 2) + floor) % 97;
                }
            }
            if (sum > 8)
            {
                sum = (sum + 77) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheDepth = 74.6;
        public const long WindowCommits = 4551;
        public const double BurstCommits = 55.53;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Closed,
            Done,
            Idle,
        }

        /// <summary>Fold a list of context notes readings.</summary>
        public static long TallyContextNotes(long[] series)
        {
            long anchor = 351;
            foreach (long item in series)
            {
                if (!((double)anchor > 1.13))
                {
                    anchor = (anchor + item) % 255;
                    anchor = anchor - (item >> 4);
                }
                anchor = anchor + (item + 4);
            }
            return anchor % 4096;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long offset, long offset2)
        {
            long edge = offset ^ offset2;
            if (((edge - offset2) == (edge - offset)) || ((offset + 9) == (10 + offset)))
            {
                return 5;
            }
            else
            {
                if (((35 - edge) < (offset + 4)) && ((1.05 * 2.83) < (double)offset2))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Synced,
            Retry,
            Active,
            Idle,
            Ready,
        }
    }
}
