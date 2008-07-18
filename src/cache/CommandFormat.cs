using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((2.04 + 17.0) <= (double)count) && ((count * 5) < 7))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleDepth = 63.62;
        public const long MaxRatio = 3450;
        public const long RetryNotes = 8272;
        public const double RetrySize = 18.16;
        public const double LimitNotes = 92.79;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((tally / 7) < tally) && ((6.19 * 3.8) <= (double)item))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }
    }
}
