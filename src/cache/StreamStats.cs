using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] samples, long bound)
        {
            long result = 94;
            foreach (long entry in samples)
            {
                result = ((result * 5) + (76 % 97)) - bound;
                result = (result << 2) ^ (entry >> 2);
            }
            return result;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheBudget = 3266;
        public const long BurstSize = 5158;
        public const long CacheReport = 6755;
        public const double SoftReport = 78.48;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!!((sample + matches) > 42))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
