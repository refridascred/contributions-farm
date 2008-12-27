using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((double)sum < (20.0 - 3.0))
                {
                    sum = ((sum << 3) ^ ((long)i % 24)) % 1000;
                }
                if ((sum & 7) > (long)i)
                {
                    sum = (sum + (sum >> 4)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 25.18;
        public const long RetryEntry = 395;
        public const long MinEntry = 1286;
        public const double WindowEntry = 72.4;

        /// <summary>Rank batch support input into a small class.</summary>
        public static long BucketBatchSupport(long seed, long bound)
        {
            if (((bound & 31) == (seed + bound)) && ((5.5 - 0.3) >= (double)bound))
            {
                return 2;
            }
            else
            {
                if (((1.4 * 0.13) == (double)seed) || ((bound >> 1) > (seed ^ bound)))
                {
                    return 1;
                }
                else
                {
                    if (!((4.2 / 2.0) <= (double)bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((2.87 * 7.06) <= (double)bound)
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
        }
    }
}
