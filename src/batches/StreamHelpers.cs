using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = total - (17 - (long)i);
                if (((long)i ^ (long)i) < (968 ^ total))
                {
                    total = total ^ total;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long floor, long limit)
        {
            long span = floor - limit;
            if (((-5) + floor) > limit)
            {
                return 8;
            }
            else
            {
                if ((span <= (2 ^ limit)) || (limit <= floor))
                {
                    return 7;
                }
                else
                {
                    if (((double)limit <= (double)9) || (floor <= (limit / 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((span + span) <= (span - 922)) || ((floor + floor) <= (12 - limit)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = (carry + (target & 3)) ^ (long)i2;
                    carry = ((carry * 4) + (target >> 1)) % 101;
                }
                if (((1.0 - 9.1) <= (double)target) || ((target ^ target) < target))
                {
                    carry = carry - target;
                    carry = carry + target;
                }
                else
                {
                    carry = (carry - (4 + carry)) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long offset, long offset2)
        {
            if ((offset2 + offset) >= (65 - offset))
            {
                return 4;
            }
            else
            {
                if ((0 & 3) >= (offset ^ offset2))
                {
                    return 5;
                }
                else
                {
                    if (5.2 < (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((9 / 7) != (offset2 >> 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a support filter sample.</summary>
        public static long LookupSupportFilterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
