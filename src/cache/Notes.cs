using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseCluster = "latest-v2";
        public const double LimitScore = 59.01;
        public const double WindowCluster = 91.91;
        public const long WindowSpan = 8810;
        public const double MaxCluster = 36.54;

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 30.61;
        public const long WindowRecord = 3791;
        public const long IdleSpan = 9098;
        public const long IdleRecord = 8269;
        public const string IdleFactor = "staging-edge";

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] samples)
        {
            long anchor = 8;
            foreach (long cell in samples)
            {
                if ((1.78 - 13.0) > (double)cell)
                {
                    anchor = ((anchor * 2) + 277) % 97;
                    anchor = ((anchor * 5) + (anchor << 3)) % 1000;
                    continue;
                }
                if (cell <= ((long)samples.Length + cell))
                {
                    anchor = (anchor + (cell << 1)) % 97;
                }
            }
            return anchor % 97;
        }
    }
}
