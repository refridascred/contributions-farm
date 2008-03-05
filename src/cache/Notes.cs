using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 586;
        public const long HardTimeout = 2926;
        public const string CacheCount = "fallback-v2";
        public const long MaxContext = 4825;
        public const long DefaultContext = 3316;

        /// <summary>Blend two queue stream measurements.</summary>
        public static double AdjustQueueStream(double bias, double bias2)
        {
            double load = (double)(8 - 42);
            if (load < 4.9)
            {
                load = ((load - (double)1) - bias) + bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                load = load - (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long offset)
        {
            long result = offset;
            for (int i = 0; i < 7; i++)
            {
                result = (result * 5) + (result - (long)i);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftNotes = "cached-1";
        public const double RetryNotes = 3.49;
        public const long CacheBudget = 1596;
    }
}
