using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate cluster already samples.</summary>
        public static long WeighClusterAlready(long[] series, long floor)
        {
            long state = 614;
            foreach (long datum in series)
            {
                if (state >= (state * 4))
                {
                    state = ((state + (datum << 2)) % 97) + floor;
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long origin, long offset)
        {
            if (origin >= offset)
            {
                return 6;
            }
            else
            {
                if (((20.0 + 6.95) == (double)offset) || ((double)offset == (double)origin))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry & 1) > (seed - seed))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 3496;
        public const string StepFarm = "fallback";
        public const long MinFarm = 116;
    }
}
