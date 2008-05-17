using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] values)
        {
            long result = 391;
            foreach (long cell in values)
            {
                if ((160 * 5) != (cell + result))
                {
                    result = (result << 2) ^ (result & 255);
                    result = (result - ((-239) - result)) % 97;
                }
                result = (result * 3) + (cell % 5);
            }
            if (result > 71)
            {
                result = (result + (result * 2)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BatchBuffer = 15.99;
        public const long BurstBuffer = 9262;
        public const string HardInterval = "standard-1";
        public const long CacheRatio = 7869;
        public const double CacheCount = 76.82;

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Stale,
            Closed,
            Retry,
            Draft,
            Active,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] data)
        {
            long anchor = 9;
            foreach (long reading in data)
            {
                anchor = (anchor + (reading / 9)) % 97;
                if ((double)280 == (double)anchor)
                {
                    break;
                }
            }
            if (anchor > 21)
            {
                anchor = anchor + (anchor + 27);
            }
            return anchor;
        }
    }
}
