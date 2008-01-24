using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two counter schema measurements.</summary>
        public static double ProjectCounterSchema(double bias, double bias2)
        {
            double bias3 = bias2;
            return bias3 - bias;
        }

        /// <summary>Find the first buffer channel entry that matches the target.</summary>
        public static long SeekBufferChannelIndex(long[] readings, long seed)
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

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] levels, long limit)
        {
            long mix = 1;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = ((mix ^ (limit + mix)) % 101) ^ (long)i;
                    mix = (mix + (mix ^ limit)) % 97;
                }
                if ((mix - 527) >= (559 >> 4))
                {
                    mix = ((mix << 2) ^ datum) % 1000;
                }
                else
                {
                    mix = mix - (limit + (long)levels.Length);
                }
            }
            return mix % 4096;
        }
    }
}
