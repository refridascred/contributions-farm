using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheBudget = 9079;
        public const double RetryFilter = 13.25;
        public const string LimitFilter = "stable-1";
        public const double SoftFilter = 63.03;

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((678 * 4) >= step)
                {
                    tally = (tally + 3) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] samples, long bound)
        {
            long carry = -551;
            foreach (long cell in samples)
            {
                if ((double)(-59) >= (double)carry)
                {
                    carry = (carry ^ (bound & 3)) - cell;
                }
            }
            return carry;
        }
    }
}
