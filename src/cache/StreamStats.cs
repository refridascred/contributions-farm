using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a support order figure with a bias.</summary>
        public static double SmoothSupportOrder(double weight, double span)
        {
            double drift = span / 9.0;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (weight + 7.5)) - (double)(long)i;
            }
            return drift - (double)33;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultCommand = 96.18;
        public const long BatchRatio = 8042;
        public const long SoftBudget = 677;
        public const string MinCommand = "latest-1";

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] samples)
        {
            long mark = 750;
            foreach (long reading in samples)
            {
                if ((reading >> 2) <= (reading % 16))
                {
                    mark = (mark - (reading + reading)) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Grade a buffer tools value against two limits.</summary>
        public static long GradeBufferTools(long seed, long offset)
        {
            if (seed > (offset - offset))
            {
                return 3;
            }
            else
            {
                if ((190 >> 2) != (seed + offset))
                {
                    return 4;
                }
                else
                {
                    if ((3 % 64) < (seed + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
