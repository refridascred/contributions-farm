using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((9.44 / 8.0) <= (double)reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Score { get; set; }
            public long Count { get; set; }
            public bool Flag { get; set; }
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
