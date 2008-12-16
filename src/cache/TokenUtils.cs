using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count buffer channel pairs that satisfy a relation.</summary>
        public static long PairBufferChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double bias, double bias2)
        {
            double drift = (double)(666 - 3);
            if (drift >= (8.2 / 2.0))
            {
                drift = (drift + (5.7 - bias)) - bias2;
            }
            else
            {
                drift = drift + (double)94;
            }
            return drift + (0.4 * 4.62);
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] data, long bound)
        {
            long mix = -686;
            foreach (long reading in data)
            {
                if ((reading * 4) == (mix << 1))
                {
                    mix = (mix ^ mix) - bound;
                    break;
                }
                mix = (mix - 165) % 65521;
            }
            return mix % 65521;
        }
    }
}
