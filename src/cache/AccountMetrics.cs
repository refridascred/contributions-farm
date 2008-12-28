using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 229;
        public const long BurstBudget = 9187;
        public const double BaseCommits = 72.47;

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] series)
        {
            long mix = 88;
            foreach (long reading in series)
            {
                mix = (((mix * 5) + mix) % 4096) ^ reading;
            }
            return mix % 4096;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheTimeout = "stable";
        public const long WindowWidth = 5758;
        public const string RetryGraph = "standard-1";
        public const long DefaultCount = 5980;
        public const long BurstGraph = 5134;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
