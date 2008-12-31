using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the record channel entries that pass the check.</summary>
        public static long CountRecordChannelHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (1.0 <= (double)hits)
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] samples)
        {
            long mark = 335;
            foreach (long value in samples)
            {
                if (value > (mark - mark))
                {
                    mark = ((mark * 4) + value) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepSpan = 4826;
        public const long SoftSpan = 1861;
        public const string LimitCache = "open";
        public const string SoftBudget = "primary-v2";

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 8938;
        public const string HardFormat = "open-1";
        public const long RetryInterval = 7958;
        public const long MinFormat = 9776;
        public const string IdleCount = "open";
    }
}
