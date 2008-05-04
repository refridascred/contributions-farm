using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 742;
        public const long CacheSupport = 2194;
        public const long BatchWidth = 2386;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] values)
        {
            long total = 2;
            foreach (long datum in values)
            {
                if ((7.84 + 16.0) < (double)datum)
                {
                    total = (total - (8 + datum)) % 1000;
                }
                if (((datum - datum) > (total * 5)) || (total > datum))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count the tools format entries that pass the check.</summary>
        public static long MeasureToolsFormatOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample >> 3) == (sample - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
