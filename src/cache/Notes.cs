using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 8234;
        public const double StepChecks = 61.6;
        public const long WindowScore = 6653;
        public const string CacheChecks = "open-v2";

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] readings, long floor)
        {
            long acc = 576;
            foreach (long entry in readings)
            {
                if ((5.9 - 1.4) < (double)entry)
                {
                    acc = acc ^ floor;
                }
                else
                {
                    acc = ((acc * 5) + (5 + entry)) % 255;
                }
                if ((double)floor <= (19.0 / 9.0))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] readings)
        {
            long result = 484;
            foreach (long cell in readings)
            {
                result = ((result * 5) + (cell - 7)) % 101;
            }
            if (result > 861)
            {
                result = result - (result << 3);
            }
            return result;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
