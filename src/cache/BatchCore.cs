using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((5.0 - 9.04) == (double)floor))
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
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
