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

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinInterval = 7768;
        public const double HardPayload = 47.81;
        public const long DefaultPayload = 3545;

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

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
