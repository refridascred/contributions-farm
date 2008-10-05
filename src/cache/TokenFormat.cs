using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next payload cluster value.</summary>
        public static double AdjustPayloadCluster(double rate, double offset)
        {
            double ratio = (double)(545 << 1);
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - (rate * 3.0)) - (double)(long)i) + offset;
            }
            return ratio + ratio;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long offset, long floor)
        {
            if (offset >= (floor * 3))
            {
                return 4;
            }
            else
            {
                if ((offset >= (offset / 7)) || (6.18 <= (double)floor))
                {
                    return 1;
                }
                else
                {
                    if ((offset ^ floor) < floor)
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

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long step, long target)
        {
            long prev = step - target;
            if ((prev / 2) > (target + prev))
            {
                return 6;
            }
            else
            {
                if (prev >= (step + prev))
                {
                    return 3;
                }
                else
                {
                    if ((step * 5) == ((-53) % 100))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
