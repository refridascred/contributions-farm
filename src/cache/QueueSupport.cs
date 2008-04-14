using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxSpan = 2011;
        public const long StepToken = 1311;
        public const long MinBudget = 5989;
        public const long LimitToken = 671;
        public const long StepWidth = 9605;

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Score { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((target & 7) < (target ^ hits))
                {
                    hits = (hits + 2) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
