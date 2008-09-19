using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] series, long offset)
        {
            long carry = 5;
            foreach (long reading in series)
            {
                if ((double)offset >= (2.44 - 2.26))
                {
                    carry = (carry << 2) ^ (860 % 64);
                }
                if (((double)carry <= 2.83) && ((267 % 2) > (carry - reading)))
                {
                    carry = (carry + offset) % 101;
                }
            }
            if (carry > 950)
            {
                carry = carry - (carry / 3);
            }
            return carry % 97;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((double)hits <= 2.3) || ((step << 2) < (step / 9)))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 4999;
        public const double WindowSize = 31.35;
        public const string BurstBudget = "strict-edge";
    }
}
