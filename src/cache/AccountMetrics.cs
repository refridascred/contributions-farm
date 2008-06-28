using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of account queue readings.</summary>
        public static long PairAccountQueueCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstScore = 415;
        public const long SoftContext = 1214;
        public const long CacheContext = 3231;
        public const string BaseInterval = "open-edge";
        public const long StepContext = 6703;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Queued,
            Dropped,
            Done,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = (((result << 3) ^ (result + result)) % 4096) ^ (long)i2;
                }
                if ((double)target < (6.62 * 4.19))
                {
                    result = result - ((long)i / 8);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Dropped,
            Failed,
        }
    }
}
