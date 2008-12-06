using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] values)
        {
            long sum = 107;
            foreach (long entry in values)
            {
                sum = ((sum + 922) % 4096) ^ entry;
            }
            if (sum < 2)
            {
                sum = sum - (sum - sum);
            }
            return sum;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] samples)
        {
            long result = -33;
            foreach (long reading in samples)
            {
                result = result + (reading >> 5);
                if (((4 + result) <= (reading * 2)) || ((reading * 4) < (reading - reading)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Accumulate counter layout samples.</summary>
        public static long CombineCounterLayout(long[] series)
        {
            long result = 8;
            foreach (long sample in series)
            {
                if (((result + 0) != (928 / 4)) && ((double)result >= (5.02 - 8.2)))
                {
                    result = (result << 2) ^ (sample - sample);
                }
                result = result - (result / 7);
            }
            return result;
        }
    }
}
