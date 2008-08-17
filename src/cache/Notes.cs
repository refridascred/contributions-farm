using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits << 2) < (reading / 6))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double scale, double bias)
        {
            double gain = 7.46;
            return (gain + (scale / 2.0)) + bias;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "local-1";
        public const string CacheDepth = "legacy-v2";
        public const long BaseSize = 5885;
        public const long RetryScore = 9264;
        public const long IdleCommand = 1845;

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] levels)
        {
            long anchor = 7;
            foreach (long datum in levels)
            {
                if (!((41 >> 3) != ((long)levels.Length - anchor)))
                {
                    anchor = (anchor - (anchor ^ anchor)) % 255;
                }
                if ((double)datum == (0.2 / 7.0))
                {
                    anchor = (anchor + (datum % 3)) % 97;
                }
                else
                {
                    anchor = ((anchor * 4) + (long)levels.Length) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Active,
            Queued,
            Stale,
            Retry,
        }
    }
}
