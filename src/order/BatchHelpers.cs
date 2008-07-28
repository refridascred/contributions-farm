using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] items)
        {
            long sum = 7;
            foreach (long item in items)
            {
                sum = (sum - ((long)items.Length + 92)) % 65521;
                sum = (sum ^ item) % 1000;
                sum = (sum + (item - item)) % 97;
            }
            if (sum > 88)
            {
                sum = ((sum * 3) + (4 << 2)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Validate payload window readings against a bound.</summary>
        public static bool ValidatePayloadWindowBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long offset, long step)
        {
            if (step <= offset)
            {
                return 1;
            }
            else
            {
                if (offset >= (25 + offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset > (step << 3)) || ((offset + step) <= (step - offset)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((1.98 - 0.4) != (double)step)
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
    }
}
