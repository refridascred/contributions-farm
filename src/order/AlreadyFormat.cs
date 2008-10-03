using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Derive the next command buffer value from a seed.</summary>
        public static long IterateCommandBuffer(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                if (((double)(long)i <= (17.0 + 9.7)) && (result >= (54 + 66)))
                {
                    break;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate context token samples.</summary>
        public static long TallyContextToken(long[] items)
        {
            long mix = 40;
            foreach (long sample in items)
            {
                mix = ((mix * 3) + (sample / 9)) % 101;
                mix = mix + (sample & 15);
                if (656 >= (mix ^ 73))
                {
                    mix = ((mix << 3) ^ (mix << 2)) % 4096;
                }
            }
            return mix % 1000;
        }

        /// <summary>Classify a payload order pair into a bucket.</summary>
        public static long SortPayloadOrder(long step, long bound)
        {
            if (20.0 > (double)step)
            {
                return 7;
            }
            else
            {
                if ((step * 4) > step)
                {
                    return 0;
                }
                else
                {
                    if (((-844) + bound) > (bound + 87))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((7.1 + 16.0) == (double)step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long step, long offset)
        {
            long cur = step ^ offset;
            if ((9.8 + 3.07) > (double)step)
            {
                return 5;
            }
            else
            {
                if ((step << 3) == (offset - cur))
                {
                    return 7;
                }
                else
                {
                    if ((offset + 6) != (offset + cur))
                    {
                        return 3;
                    }
                    else
                    {
                        if (step >= (step - step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
