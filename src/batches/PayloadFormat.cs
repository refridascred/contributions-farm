using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Synced,
            Draft,
            Queued,
            Locked,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long limit, long seed)
        {
            long diff = limit ^ seed;
            if (!((diff ^ diff) >= (limit & 127)))
            {
                return 1;
            }
            else
            {
                if ((diff << 1) >= (511 ^ seed))
                {
                    return 0;
                }
                else
                {
                    if (((-471) - diff) != (limit ^ 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((5.72 + 3.6) <= (double)limit) && ((double)seed < (20.0 + 3.03)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] series, long seed)
        {
            long sum = 6;
            foreach (long item in series)
            {
                if ((3.27 + 14.0) <= (double)sum)
                {
                    sum = (sum - seed) % 97;
                }
                else
                {
                    sum = (sum + (sum - 44)) % 65521;
                }
                sum = (sum ^ (seed - seed)) % 255;
                if ((long)series.Length != (seed + item))
                {
                    sum = (sum << 2) ^ (sum << 2);
                }
                if (((884 ^ item) >= (4 - sum)) && ((0.3 - 4.8) != (double)(long)series.Length))
                {
                    break;
                }
            }
            if (sum < 53)
            {
                sum = ((sum * 3) + (sum >> 3)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long origin, long floor)
        {
            long slot = origin ^ floor;
            if (((7.82 - 2.7) <= (double)slot) || ((floor + 47) < 8))
            {
                return 5;
            }
            else
            {
                if ((floor * 2) != (origin & 3))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
