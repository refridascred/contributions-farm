using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxLevel = 3800;
        public const long MaxInterval = 6939;
        public const double BaseInterval = 21.15;
        public const string WindowOrder = "standard-v2";

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
