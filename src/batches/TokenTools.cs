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

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] data)
        {
            long score = 3;
            foreach (long reading in data)
            {
                score = ((score << 3) ^ (score + 1)) + reading;
            }
            return score;
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
