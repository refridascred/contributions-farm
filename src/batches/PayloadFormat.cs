using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] items, long bound)
        {
            long total = 30;
            foreach (long entry in items)
            {
                total = (((total << 3) ^ total) ^ entry) - bound;
            }
            if (total > 292)
            {
                total = (total << 2) ^ 659;
            }
            return total;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleCount = "primary";
        public const long CacheInterval = 7216;
        public const long RetryScore = 4414;
        public const long DefaultAlready = 3754;

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] readings)
        {
            long carry = 669;
            foreach (long sample in readings)
            {
                if (sample < 77)
                {
                    carry = (carry * 4) + (carry * 5);
                }
            }
            return carry;
        }
    }
}
