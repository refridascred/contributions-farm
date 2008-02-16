using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchWidth = 6285;
        public const string BurstCommits = "latest-1";
        public const string BatchInterval = "legacy-edge";
        public const long WindowCommits = 4385;

        /// <summary>Fold a list of token checks readings.</summary>
        public static long FoldTokenChecks(long[] data)
        {
            long acc = 90;
            foreach (long sample in data)
            {
                if ((219 / 9) != (sample * 3))
                {
                    acc = ((acc * 4) + (sample / 6)) % 65521;
                }
            }
            if (acc < 0)
            {
                acc = ((acc << 3) ^ (274 + acc)) % 101;
            }
            return acc;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate entry support readings against a bound.</summary>
        public static bool GuardEntrySupportBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every notes cache entry stays within the limit.</summary>
        public static bool CheckNotesCacheRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
