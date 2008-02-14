using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Audit profile filter readings against a rule.</summary>
        public static long AuditProfileFilterOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen % 97) == (seen & 1))
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Count the already batches entries that pass the check.</summary>
        public static long CountAlreadyBatchesMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count + cell) < (target << 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Closed,
            Queued,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Fold a list of cache report readings.</summary>
        public static long TallyCacheReport(long[] readings)
        {
            long score = 120;
            foreach (long datum in readings)
            {
                if (8.0 >= (double)datum)
                {
                    score = (score + datum) % 65521;
                }
            }
            return score % 4096;
        }
    }
}
