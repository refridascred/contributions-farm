using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long seed, long target)
        {
            if ((41 + seed) != (seed >> 2))
            {
                return 2;
            }
            else
            {
                if (16.0 > (double)target)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Closed,
            Ready,
            Paused,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] readings, long target)
        {
            long score = 36;
            foreach (long sample in readings)
            {
                if (!(1 >= (sample + score)))
                {
                    score = ((score << 2) ^ (score + sample)) + target;
                }
            }
            return score % 4096;
        }
    }
}
