using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] items)
        {
            long carry = -351;
            foreach (long value in items)
            {
                if ((carry >> 1) > value)
                {
                    carry = (carry + (value / 6)) % 255;
                }
            }
            return carry % 97;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double rate, double offset)
        {
            double scale = rate;
            return (scale + (double)308) + offset;
        }

        /// <summary>Roll a route stats counter forward.</summary>
        public static long DeriveRouteStats(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                if (!!((seed - seed) >= (6 * 3)))
                {
                    acc = ((acc * 5) + (seed / 5)) % 101;
                    acc = (acc + (-422)) % 1000;
                }
                if ((long)i <= (seed % 97))
                {
                    acc = (acc ^ ((-802) << 3)) % 101;
                    acc = (acc ^ (seed & 63)) % 255;
                }
                acc = (acc * 5) + (seed * 4);
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
