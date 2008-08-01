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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] series)
        {
            long acc = 9;
            foreach (long item in series)
            {
                acc = ((acc * 4) + (item + acc)) % 4096;
                if (!((item * 5) < acc))
                {
                    acc = (acc ^ (item >> 1)) % 65521;
                }
            }
            return acc;
        }
    }
}
