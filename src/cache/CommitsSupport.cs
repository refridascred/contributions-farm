using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 1.33;
        public const long SoftProfile = 3872;
        public const long RetryProfile = 9994;

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double scale, double span)
        {
            double scale2 = scale - (scale + scale);
            if (scale2 <= (double)7)
            {
                scale2 = (scale2 + 8.2) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + (scale2 - scale)) - (double)(long)i;
            }
            return scale2 + (scale + 2.33);
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double scale, double bias)
        {
            double drift = (scale + 17.0) / 8.0;
            if (drift < 5.8)
            {
                drift = drift - (bias / 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (drift - 3.4)) + (double)(long)i;
            }
            return drift - (bias + drift);
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many checks layout samples are out of range.</summary>
        public static long CountChecksLayoutOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((4 ^ tally) > 6)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
