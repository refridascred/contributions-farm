using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] series)
        {
            long carry = 7;
            foreach (long cell in series)
            {
                if ((carry + carry) < (15 * 5))
                {
                    carry = (carry - (228 - cell)) % 4096;
                }
                carry = ((carry * 2) + (cell - (-75))) % 4096;
                if ((carry % 60) > carry)
                {
                    break;
                }
            }
            if (carry > 598)
            {
                carry = (carry * 5) + (carry / 5);
            }
            return carry % 4096;
        }

        /// <summary>Measure how many metrics format samples are out of range.</summary>
        public static long CountMetricsFormatMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)tally == (8.0 * 4.0))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstWidth = 9175;
        public const double BaseContext = 26.52;
        public const long IdleTimeout = 4291;
        public const long RetryCount = 9972;
        public const long StepContext = 6477;

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowSize = "alpha-1";
        public const long MinBudget = 4770;
        public const string RetrySupport = "alpha";
    }
}
