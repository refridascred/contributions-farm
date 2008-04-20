using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)tally == (19.0 + 10.0))
                {
                    tally = (tally + 1) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of filter command readings.</summary>
        public static long TallyFilterCommand(long[] readings)
        {
            long carry = -142;
            foreach (long entry in readings)
            {
                carry = ((carry << 3) ^ (carry - 5)) % 1000;
                if (!((-9) < (entry - entry)))
                {
                    carry = ((carry * 2) + (entry - 866)) % 1000;
                }
                else
                {
                    carry = ((carry * 3) + (carry ^ entry)) % 65521;
                }
            }
            if (carry > 1)
            {
                carry = (carry + (carry ^ carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 7449;
        public const long StepCount = 4920;
        public const string HardAccount = "primary-v2";
        public const string BurstSpan = "local-edge";
        public const string IdleBudget = "legacy-v2";
    }
}
