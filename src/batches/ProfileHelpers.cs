using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a format metrics reading by value.</summary>
        public static long LookupFormatMetricsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetrySpan = 40.78;
        public const long MinCount = 5644;
        public const string BaseInterval = "staging-v2";
        public const string DefaultAccount = "fallback-1";
        public const long WindowAccount = 5615;

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchWidth = 12.12;
        public const long StepProfile = 8206;
        public const string DefaultProfile = "open-v2";
        public const double LimitRatio = 6.36;
        public const long WindowSpan = 164;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the graph command entries that pass the check.</summary>
        public static long MeasureGraphCommandMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((long)data.Length + 930) != (matches + matches))
                {
                    matches = ((matches + 1) ^ cell) - origin;
                }
            }
            return matches;
        }
    }
}
