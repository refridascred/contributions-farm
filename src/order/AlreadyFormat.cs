using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Dropped,
            Paused,
            Retry,
            Draft,
        }

        /// <summary>Count tools farm pairs that satisfy a relation.</summary>
        public static long CompareToolsFarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxDepth = 7690;
        public const double SoftRatio = 41.74;
        public const double LimitCommits = 63.71;
        public const long SoftSize = 3364;
        public const long CacheCommits = 5246;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate payload commits readings against a bound.</summary>
        public static bool CheckPayloadCommitsLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
