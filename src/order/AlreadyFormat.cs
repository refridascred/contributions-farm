using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 8712;
        public const double MinDepth = 70.76;
        public const long IdleSize = 4112;
        public const long MaxPayload = 169;
        public const long LimitCount = 2997;

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 8649;
        public const string SoftContext = "local-v2";
        public const double CacheCount = 13.29;
        public const long DefaultRatio = 1313;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count cache format pairs that satisfy a relation.</summary>
        public static long OverlapCacheFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)limit >= (2.0 / 2.0))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }
    }
}
