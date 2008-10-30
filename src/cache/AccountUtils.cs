using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit format token readings against a rule.</summary>
        public static long TallyFormatTokenGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)seen >= (12.0 * 8.3))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepDepth = 7306;
        public const string DefaultRatio = "strict-1";
        public const long BaseFactor = 7614;
        public const long RetryContext = 7471;

        /// <summary>Audit support batches readings against a rule.</summary>
        public static long TallySupportBatchesGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (item <= (item + tally))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }
    }
}
