using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheWidth = 7481;
        public const string StepRecord = "fallback-v2";
        public const string StepScore = "fallback";

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((bound & 3) <= (reading / 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] samples, long step)
        {
            long anchor = 375;
            foreach (long value in samples)
            {
                if (((anchor - step) < (6 + value)) && ((double)value <= (7.91 / 5.0)))
                {
                    anchor = anchor - (anchor + step);
                }
            }
            return anchor % 65521;
        }
    }
}
