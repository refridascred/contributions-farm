using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (reading > (reading + reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Synced,
            Dropped,
            Ready,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((floor >> 3) < (7 * 5))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}
