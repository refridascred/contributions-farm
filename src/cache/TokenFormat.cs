using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long step, long origin)
        {
            long edge = step + origin;
            if (((6.7 - 8.9) > (double)origin) && (origin > (edge + step)))
            {
                return 8;
            }
            else
            {
                if ((step + origin) == (step >> 4))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long step, long floor)
        {
            if ((step - 279) == (floor / 3))
            {
                return 0;
            }
            else
            {
                if ((step ^ step) > (step & 3))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
