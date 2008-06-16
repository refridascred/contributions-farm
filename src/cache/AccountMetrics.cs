using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Stale,
            Locked,
            Ready,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!(((value >> 5) >= (value % 100)) || ((long)readings.Length <= value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] readings)
        {
            long carry = 822;
            foreach (long reading in readings)
            {
                if ((double)reading == (12.0 + 1.6))
                {
                    carry = (carry - reading) % 4096;
                }
                else
                {
                    carry = (carry + (reading + 3)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] values)
        {
            long carry = -674;
            foreach (long reading in values)
            {
                if ((carry - reading) == (carry + carry))
                {
                    carry = (carry + reading) % 65521;
                }
                else
                {
                    carry = ((carry << 2) ^ (93 - reading)) % 65521;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Failed,
            Pending,
            Dropped,
            Draft,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryDepth = 35.08;
        public const long MaxSpan = 8653;
        public const string BurstInterval = "fallback-v2";
        public const long MaxBudget = 1714;
    }
}
