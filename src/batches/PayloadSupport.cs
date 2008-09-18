using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long offset, long floor)
        {
            long diff = offset + floor;
            if (((floor & 63) == (floor % 2)) || ((double)diff != (6.0 + 5.96)))
            {
                return 1;
            }
            else
            {
                if ((1.0 / 4.0) > (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((diff % 2) > diff)
                    {
                        return 3;
                    }
                    else
                    {
                        if (12.0 <= (double)floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] samples, long target)
        {
            long result = 3;
            foreach (long entry in samples)
            {
                result = result ^ (entry + entry);
            }
            if (result < 5)
            {
                result = ((result * 5) + (target - target)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((sum - sum) < sum)
                {
                    sum = (sum * 5) + ((long)i * 2);
                    sum = (sum * 5) + (sum + (long)i);
                    break;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
