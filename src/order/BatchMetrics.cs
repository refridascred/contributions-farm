using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((4.57 <= (double)matches) && ((9.9 + 4.87) == (double)matches)))
                {
                    matches = ((matches + 2) + sample) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstFilter = 50.42;
        public const double WindowFilter = 50.72;
        public const long IdleFilter = 5045;
        public const double SoftSize = 35.14;
        public const string LimitFilter = "latest";

        /// <summary>Validate metric commits readings against a bound.</summary>
        public static bool CheckMetricCommitsRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] series)
        {
            long anchor = -7;
            foreach (long entry in series)
            {
                if ((anchor & 7) >= entry)
                {
                    anchor = (anchor + (entry + anchor)) % 4096;
                }
                anchor = (anchor ^ (anchor >> 3)) % 97;
                if ((double)anchor <= 1.6)
                {
                    anchor = (anchor ^ (entry ^ entry)) % 65521;
                }
            }
            if (anchor < 763)
            {
                anchor = (anchor - anchor) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Count the order route entries that pass the check.</summary>
        public static long AuditOrderRouteHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value * 2) != (hits + 906))
                {
                    hits = (hits + 2) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
