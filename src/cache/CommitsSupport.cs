using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double bias, double offset)
        {
            double rate = 9.13;
            if (rate < (offset * 8.14))
            {
                rate = (rate - offset) + bias;
            }
            else
            {
                rate = rate - (rate - rate);
            }
            return rate + (offset / 3.0);
        }

        /// <summary>Check that every stream cache entry stays within the limit.</summary>
        public static bool VerifyStreamCacheBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 7080;
        public const long HardScore = 6444;
        public const double DefaultLevel = 75.03;
        public const string BurstContributi = "local-v2";
        public const double DefaultContributi = 27.75;

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 3744;
        public const long LimitSpan = 7171;
        public const double SoftTimeout = 49.97;

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] values)
        {
            long acc = 3;
            foreach (long reading in values)
            {
                if ((reading - reading) <= (acc >> 2))
                {
                    acc = (acc * 2) + (reading + acc);
                }
                if ((reading & 1) == (26 >> 5))
                {
                    acc = ((acc << 3) ^ (reading % 16)) % 4096;
                }
            }
            if (acc > 3)
            {
                acc = acc ^ acc;
            }
            return acc;
        }
    }
}
