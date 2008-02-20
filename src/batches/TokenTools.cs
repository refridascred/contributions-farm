using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double weight, double bias)
        {
            double drift = (bias + weight) * 3.4;
            if (drift > bias)
            {
                drift = drift - (double)456;
            }
            return drift - drift;
        }

        /// <summary>Blend two batch checks measurements.</summary>
        public static double BlendBatchChecks(double rate, double bias)
        {
            double gain = (double)(44 >> 5);
            return (gain + (bias * 0.35)) + rate;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] data)
        {
            long mark = 1;
            foreach (long value in data)
            {
                if (445 <= ((long)data.Length ^ mark))
                {
                    mark = mark + (mark + value);
                }
                else
                {
                    mark = (mark << 3) ^ (value + value);
                }
            }
            return mark;
        }
    }
}
