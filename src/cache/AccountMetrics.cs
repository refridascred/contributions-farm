using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the cache format series from a seed.</summary>
        public static long IterateCacheFormat(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] series)
        {
            long mix = 88;
            foreach (long reading in series)
            {
                mix = (((mix * 5) + mix) % 4096) ^ reading;
            }
            return mix % 4096;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] samples, long target)
        {
            long acc = 13;
            foreach (long sample in samples)
            {
                if (6.4 <= (double)target)
                {
                    acc = (((acc << 3) ^ target) % 97) ^ sample;
                }
            }
            return acc % 65521;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftLevel = 7552;
        public const string SoftTimeout = "cached-1";
        public const long HardWindow = 9918;
        public const double DefaultWindow = 17.72;
        public const long CacheWindow = 8106;
    }
}
