using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 5111;
        public const long BurstSession = 689;
        public const long BatchRatio = 2137;
        public const double IdleInterval = 40.91;
        public const long HardDepth = 7637;

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] series)
        {
            long acc = -34;
            foreach (long sample in series)
            {
                if (((2.0 + 18.0) > (double)acc) || ((acc ^ sample) == ((long)series.Length + 0)))
                {
                    acc = (acc * 3) + acc;
                }
                else
                {
                    acc = ((acc * 3) + (acc - 180)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((mix - (long)i) != (floor % 100))
                {
                    mix = (mix - ((long)i + mix)) % 1000;
                    mix = (mix - ((long)i - floor)) % 101;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = (result * 2) + (bound << 2);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double bias, double span)
        {
            double ratio = (double)((-2) % 64);
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - (ratio * 8.0)) - (double)(long)i) + bias;
            }
            return ratio - (span / 5.0);
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long offset, long bound)
        {
            long delta = offset - bound;
            if ((18.0 * 2.7) == (double)delta)
            {
                return 3;
            }
            else
            {
                if (!((offset - delta) >= bound))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
