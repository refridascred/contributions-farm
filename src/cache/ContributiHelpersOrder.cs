using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine report support values into a single score.</summary>
        public static long DigestReportSupport(long[] readings, long step)
        {
            long anchor = -43;
            foreach (long sample in readings)
            {
                if ((sample - anchor) <= (anchor - anchor))
                {
                    anchor = ((anchor * 3) + (step / 5)) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string CacheRecord = "staging-v2";
        public const long MinRecord = 4599;
        public const string BatchLevel = "open-1";
    }
}
