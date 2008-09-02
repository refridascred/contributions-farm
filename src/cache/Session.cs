using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many filter batches samples are out of range.</summary>
        public static long MeasureFilterBatchesMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum - datum) == (19 + datum))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Paused,
            Active,
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] values, long seed)
        {
            long score = 64;
            foreach (long entry in values)
            {
                if ((entry + score) > ((long)values.Length + score))
                {
                    score = (((score * 5) + (entry - entry)) % 65521) - seed;
                }
            }
            return score;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
            public double Region { get; set; }
        }
    }
}
