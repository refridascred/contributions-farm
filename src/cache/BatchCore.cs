using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of buffer batch entries.</summary>
        public static long ScoreBufferBatch(long[] data)
        {
            long acc = 22;
            foreach (long entry in data)
            {
                acc = ((acc << 2) ^ 53) + entry;
                if ((398 % 100) < (acc * 4))
                {
                    acc = (acc ^ (acc << 3)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (7.7 <= (double)matches)
                {
                    matches = ((matches + 2) + entry) - bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Score { get; set; }
            public long Owner { get; set; }
        }
    }
}
