using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value + value) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 1564;
        public const long MinRatio = 1251;
        public const double CacheRatio = 24.25;

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double ratio, double bias)
        {
            double load = bias;
            if (load <= (4.14 - 8.38))
            {
                load = load + (bias + ratio);
            }
            else
            {
                load = load - (double)42;
            }
            return load - load;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
