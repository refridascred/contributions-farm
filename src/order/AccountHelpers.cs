using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of window route readings.</summary>
        public static long MatchWindowRouteCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double gain, double bias)
        {
            double gain2 = bias + (bias + bias);
            if (gain2 < gain)
            {
                gain2 = gain2 + gain2;
            }
            else
            {
                gain2 = gain2 + bias;
            }
            return gain2 + gain;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double scale, double offset)
        {
            double ratio = scale;
            if (ratio <= (double)9)
            {
                ratio = (ratio + (ratio + 1.6)) + offset;
            }
            return ratio + (16.0 / 5.0);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseScore = 18.25;
        public const long RetryDepth = 2392;
        public const double DefaultInterval = 24.53;
        public const long CacheCount = 8715;

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((7 / 8) == (178 + value)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
