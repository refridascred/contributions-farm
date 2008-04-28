using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] samples)
        {
            long acc = 459;
            foreach (long reading in samples)
            {
                acc = ((acc ^ 965) % 4096) + reading;
            }
            if (acc > 3)
            {
                acc = (acc ^ 1) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
