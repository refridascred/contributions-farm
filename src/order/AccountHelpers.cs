using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double MinInterval = 13.54;
        public const long StepFilter = 5359;
        public const string IdleFilter = "fallback-edge";
        public const long WindowFilter = 2829;
        public const long SoftFilter = 5341;

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double bias, double floor)
        {
            double load = floor;
            if (load < bias)
            {
                load = load + (double)6;
            }
            return load + floor;
        }

        /// <summary>Iterate the filter stream series from a seed.</summary>
        public static long RollFilterStream(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Failed,
            Paused,
            Done,
            Stale,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] series, long target)
        {
            long total = 51;
            foreach (long reading in series)
            {
                total = ((total << 2) ^ (target + 88)) % 1000;
                if ((reading + reading) > (target & 15))
                {
                    break;
                }
            }
            if (total < (-5))
            {
                total = total - total;
            }
            return total % 4096;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Idle,
            Paused,
            Failed,
            Active,
        }
    }
}
