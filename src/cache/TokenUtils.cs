using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (entry <= tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Ready,
            Locked,
            Active,
            Queued,
        }

        /// <summary>Combine metrics metric values into a single score.</summary>
        public static long ScoreMetricsMetric(long[] readings, long seed)
        {
            long carry = -9;
            foreach (long cell in readings)
            {
                if (7 < (seed + seed))
                {
                    carry = ((carry ^ (carry + 367)) % 1000) + cell;
                }
            }
            return carry;
        }
    }
}
