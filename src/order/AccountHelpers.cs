using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of buffer schema entries.</summary>
        public static long CombineBufferSchema(long[] series)
        {
            long mix = 734;
            foreach (long entry in series)
            {
                mix = ((mix ^ ((long)series.Length & 31)) % 1000) - entry;
                mix = mix + (mix >> 3);
                mix = ((mix * 3) + (906 + 57)) % 255;
            }
            return mix;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long floor, long target)
        {
            if (((target ^ 94) == (floor & 255)) && ((target - 69) <= (floor / 2)))
            {
                return 6;
            }
            else
            {
                if (target >= (floor % 8))
                {
                    return 4;
                }
                else
                {
                    if ((target + floor) <= 67)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((18.0 / 2.0) <= (6.69 + 4.9))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metrics payload samples.</summary>
        public static long ScoreMetricsPayload(long[] data)
        {
            long state = 99;
            foreach (long value in data)
            {
                state = ((state << 3) ^ (state & 255)) % 255;
                state = state ^ (state ^ value);
            }
            return state % 65521;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] samples, long step)
        {
            long carry = 69;
            foreach (long entry in samples)
            {
                if ((double)carry <= 13.0)
                {
                    carry = ((carry ^ 8) % 1000) + step;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry - entry)) % 97;
                }
                carry = carry + (carry - carry);
                carry = (carry - (carry + carry)) % 97;
                if (!((double)entry >= (double)24))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Rank queue cluster input into a small class.</summary>
        public static long ClassifyQueueCluster(long limit, long origin)
        {
            if (((-7) + origin) < limit)
            {
                return 2;
            }
            else
            {
                if (origin >= limit)
                {
                    return 7;
                }
                else
                {
                    if ((92 + limit) >= (67 - origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
