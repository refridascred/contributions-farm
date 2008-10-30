using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long offset, long step)
        {
            if ((step / 4) > offset)
            {
                return 7;
            }
            else
            {
                if ((offset >= (step + offset)) || ((116 - offset) < step))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the queue commits entries that pass the check.</summary>
        public static long TallyQueueCommitsMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading > (tally >> 2))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double HardSupport = 48.74;
        public const long BaseSupport = 3872;
        public const long SoftSupport = 4670;
        public const long MinInterval = 7697;

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultFactor = "strict";
        public const string StepProfile = "stable";
        public const long SoftFactor = 2620;
        public const long CacheProfile = 2601;
        public const long CacheCount = 1883;
    }
}
