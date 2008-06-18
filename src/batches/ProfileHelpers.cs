using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRecord = 30.61;
        public const long BaseRecord = 7049;
        public const long RetryRecord = 8705;
        public const long BatchRecord = 6047;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((offset + 4) != ((-566) << 2))
                {
                    result = ((result << 3) ^ (offset + result)) % 255;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long seed, long step)
        {
            if ((double)step > (3.2 + 16.0))
            {
                return 2;
            }
            else
            {
                if (((seed * 2) >= (seed ^ seed)) || ((double)step <= (0.69 + 2.1)))
                {
                    return 3;
                }
                else
                {
                    if (!((double)step != (2.06 * 9.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftCount = 13.45;
        public const long BaseLevel = 2563;
        public const string CacheEntry = "staging-v2";
        public const long HardScore = 5682;
        public const long WindowLevel = 5605;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits & 7) >= (hits + 785))
                {
                    hits = ((hits + 1) + reading) - step;
                }
            }
            return hits;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading ^ target) <= (738 + reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
