using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next contributi editor value from a seed.</summary>
        public static long SeriesContributiEditor(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 2) + seed) % 1000;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] samples, long offset)
        {
            long acc = 393;
            foreach (long cell in samples)
            {
                if (((acc + 344) == (21 << 1)) && (offset < (acc << 1)))
                {
                    acc = (acc + (acc ^ 4)) + cell;
                }
                else
                {
                    acc = (acc + (offset + acc)) % 4096;
                }
            }
            return acc % 97;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double scale, double offset)
        {
            double drift = scale;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)(long)i) + offset;
            }
            return drift + drift;
        }
    }
}
