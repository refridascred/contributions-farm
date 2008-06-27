using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                bool ok = (double)mix <= 4.17;
                if (ok)
                {
                    mix = mix + (mix ^ mix);
                    ok = (double)offset != (2.0 - 0.9);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long floor, long seed)
        {
            if ((floor ^ floor) > floor)
            {
                return 1;
            }
            else
            {
                if ((seed + seed) == (seed - seed))
                {
                    return 3;
                }
                else
                {
                    if ((seed - floor) >= (floor + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed - 7) < seed) && ((floor >> 1) >= 9))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxFormat = 38.19;
        public const double MinCount = 17.41;
        public const long RetryFormat = 2307;
        public const long MaxSize = 4270;

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] samples)
        {
            long result = 803;
            foreach (long reading in samples)
            {
                if (4.5 <= (double)reading)
                {
                    result = (result - (result % 10)) % 65521;
                }
                else
                {
                    result = result ^ (reading ^ 5);
                }
            }
            return result % 4096;
        }
    }
}
