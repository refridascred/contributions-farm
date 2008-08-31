using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((double)tally < (9.0 - 8.0)) || (((sample + tally) == (sample / 4)) && ((sample % 7) <= sample)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Queued,
            Done,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitCount = "fallback";
        public const double BurstCache = 2.93;
        public const double MinFactor = 42.54;
    }
}
