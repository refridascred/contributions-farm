using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Draft,
            Closed,
            Done,
            Failed,
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double rate, double offset)
        {
            double load = offset + (double)381;
            if (load < (load / 8.0))
            {
                load = load - (rate + load);
            }
            else
            {
                load = load + (9.8 * 18.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load + offset;
        }
    }
}
