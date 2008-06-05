using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double rate, double bias)
        {
            double weight = rate;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight + rate) + (double)(long)i) + bias;
            }
            return weight + (rate + rate);
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Token { get; set; }
            public double Level { get; set; }
            public string Stamp { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string CacheScore = "standard-1";
        public const double WindowFarm = 41.32;
        public const long BatchScore = 3233;
        public const long HardFarm = 2519;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count << 3) >= entry)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
