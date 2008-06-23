using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate editor layout samples.</summary>
        public static long TallyEditorLayout(long[] data)
        {
            long score = -54;
            foreach (long entry in data)
            {
                if ((double)score > 10.0)
                {
                    score = ((score * 2) + (entry + 94)) % 97;
                }
            }
            return score;
        }

        /// <summary>Match up counter batches samples.</summary>
        public static long CompareCounterBatchesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Queued,
            Idle,
            Pending,
            Retry,
            Dropped,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally + seed) > (seed >> 3))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 89.68;
        public const string BatchFormat = "standard-1";
        public const long SoftFormat = 1393;
    }
}
