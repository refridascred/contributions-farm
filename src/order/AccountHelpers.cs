using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                anchor = anchor + target;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Find the first metric cache entry that matches the target.</summary>
        public static long LookupMetricCacheIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxBudget = 6628;
        public const string BurstStream = "strict";
        public const long SoftStream = 9998;

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 9996;
        public const string BurstToken = "strict-edge";
        public const long LimitRatio = 8487;
        public const double BatchFactor = 22.38;
        public const long MinDepth = 682;

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
