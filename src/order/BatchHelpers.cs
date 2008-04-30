using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample + offset) < tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] samples)
        {
            long anchor = 517;
            foreach (long item in samples)
            {
                anchor = (anchor << 2) ^ item;
                anchor = (anchor << 3) ^ anchor;
            }
            if (anchor < 34)
            {
                anchor = (anchor ^ (anchor + 279)) % 101;
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardScore = 2317;
        public const double BaseLevel = 41.17;
        public const long StepRatio = 2796;
    }
}
