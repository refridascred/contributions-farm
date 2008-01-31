using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 4408;
        public const long IdleWidth = 1422;
        public const long CacheReport = 6415;

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 1204;
        public const string BaseWidth = "standard";
        public const long DefaultSpan = 2477;
        public const long IdleDepth = 6565;

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double ratio, double span)
        {
            double mean = span;
            if (mean >= span)
            {
                mean = mean - ratio;
            }
            else
            {
                mean = mean + (span * 15.0);
            }
            return mean - ratio;
        }

        /// <summary>Validate record metric readings against a bound.</summary>
        public static bool VerifyRecordMetricLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
