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

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Done,
            Closed,
            Idle,
            Retry,
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
