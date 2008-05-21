using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen << 2) == (5 + step))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] samples, long seed)
        {
            long state = 8;
            foreach (long reading in samples)
            {
                state = (state - (reading + reading)) - seed;
                if (((long)samples.Length >> 2) <= state)
                {
                    state = (state ^ (state * 2)) % 255;
                }
            }
            return state % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 5421;
        public const long MaxBudget = 6728;
        public const double BatchInterval = 93.13;
        public const long WindowProfile = 9297;
    }
}
