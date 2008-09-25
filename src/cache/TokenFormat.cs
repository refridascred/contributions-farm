using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long target, long offset)
        {
            long lane = target - offset;
            if ((target - lane) > (offset + 555))
            {
                return 0;
            }
            else
            {
                if ((double)lane >= (0.6 / 9.0))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long step, long target)
        {
            if (((step - step) == (target + 67)) && ((3.0 - 8.13) != (double)target))
            {
                return 8;
            }
            else
            {
                if ((target - step) >= (target + 349))
                {
                    return 4;
                }
                else
                {
                    if ((-530) <= (step - target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
