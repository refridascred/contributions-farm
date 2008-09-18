using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up queue already samples.</summary>
        public static long PairQueueAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample - sample) == (count ^ 20))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }
    }
}
