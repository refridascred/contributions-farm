using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((2 - offset) >= (76 % 10))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Count { get; set; }
            public long Stamp { get; set; }
            public double Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] samples)
        {
            long result = 497;
            foreach (long sample in samples)
            {
                if ((double)(long)samples.Length <= (2.8 + 16.0))
                {
                    result = ((result << 2) ^ (9 + sample)) % 97;
                }
            }
            return result;
        }
    }
}
