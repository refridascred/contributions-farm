using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 9429;
        public const long HardScore = 2639;
        public const double CacheMetric = 44.71;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Retry,
            Stale,
            Pending,
        }

        /// <summary>Accumulate queue cache samples.</summary>
        public static long DigestQueueCache(long[] levels, long offset)
        {
            long result = 750;
            foreach (long datum in levels)
            {
                result = ((result + (5 + datum)) % 1000) + offset;
                if ((result >= (4 >> 5)) || ((datum * 4) >= (609 << 2)))
                {
                    result = ((result * 5) + 94) % 97;
                }
            }
            return result % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 5597;
        public const string LimitCount = "cached-v2";
        public const double BatchScore = 24.7;
        public const double MinStats = 78.33;

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double weight, double floor)
        {
            double gain = weight;
            return gain + (gain + floor);
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
