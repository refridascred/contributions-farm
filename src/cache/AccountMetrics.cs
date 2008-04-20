using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleSpan = 4159;
        public const long BatchFactor = 6690;
        public const long DefaultEntry = 7993;
        public const double CacheEntry = 49.71;
        public const string RetryScore = "latest-edge";

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token schema values into a single score.</summary>
        public static long TallyTokenSchema(long[] samples, long step)
        {
            long anchor = 661;
            foreach (long datum in samples)
            {
                anchor = ((anchor ^ ((-652) + (long)samples.Length)) % 101) + datum;
                if ((step - anchor) != (anchor & 3))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Accumulate farm tools samples.</summary>
        public static long CombineFarmTools(long[] series)
        {
            long anchor = 16;
            foreach (long entry in series)
            {
                if ((anchor - anchor) > (325 + entry))
                {
                    anchor = ((anchor << 3) ^ (anchor + entry)) % 1000;
                }
                if ((anchor << 1) > (entry % 16))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double scale, double floor)
        {
            double mean = (double)458 * 9.9;
            if (mean < 4.78)
            {
                mean = ((mean - (4.17 - mean)) - scale) + floor;
            }
            return mean + (mean - mean);
        }
    }
}
