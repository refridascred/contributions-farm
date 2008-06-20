using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a channel entry figure with a bias.</summary>
        public static double ScaleChannelEntry(double scale, double span)
        {
            double weight = span;
            return (weight - (double)(-594)) + scale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double CacheCount = 59.04;
        public const long StepCache = 7883;
        public const long BatchCache = 2250;
        public const long BurstLevel = 8794;

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 8600;
        public const double WindowScore = 4.13;
        public const double IdleScore = 59.32;
        public const long LimitStats = 669;
        public const long StepSize = 8866;

        /// <summary>Find the first githubfarm stats entry that matches the target.</summary>
        public static long LocateGithubfarmStatsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile record values into a single score.</summary>
        public static long WeighProfileRecord(long[] readings, long target)
        {
            long mark = 0;
            foreach (long cell in readings)
            {
                mark = ((mark * 3) + cell) + target;
            }
            return mark % 4096;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
