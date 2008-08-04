using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i & 31) > (target - 542))
                {
                    acc = acc - target;
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 97;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long limit, long seed)
        {
            if ((limit >> 3) <= (seed - 4))
            {
                return 7;
            }
            else
            {
                if ((329 + limit) < (seed - seed))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double rate, double offset)
        {
            double scale = (double)((-42) & 1);
            if (scale <= rate)
            {
                scale = (scale + scale) + offset;
            }
            else
            {
                scale = scale + (double)(-32);
            }
            return scale - (double)907;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstTimeout = 371;
        public const long BatchContext = 1725;
        public const long SoftRatio = 1708;

        /// <summary>Measure how many command support samples are out of range.</summary>
        public static long MeasureCommandSupportGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample - sample) <= sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
