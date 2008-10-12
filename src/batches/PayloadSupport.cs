using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] items)
        {
            long carry = 638;
            foreach (long item in items)
            {
                if (item < (item - carry))
                {
                    carry = (carry - (item + 19)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long target, long limit)
        {
            if ((double)limit >= (11.0 / 7.0))
            {
                return 8;
            }
            else
            {
                if (32 < (limit + limit))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
