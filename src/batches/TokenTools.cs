using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] series, long step)
        {
            long carry = 5;
            foreach (long item in series)
            {
                carry = (carry ^ (item % 16)) - step;
                carry = carry - (70 << 2);
            }
            return carry % 4096;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc << 3) ^ ((long)i & 63);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (acc - (limit >> 2)) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double ratio, double offset)
        {
            double drift = offset + (offset / 3.0);
            if (drift >= offset)
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (ratio / 9.0)) + (double)(long)i;
            }
            return drift - (offset / 6.0);
        }
    }
}
