using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string CacheWidth = "local-1";
        public const long RetrySize = 8240;
        public const long CacheCommand = 7195;
        public const long MinCommand = 1549;
        public const string BaseCommand = "stable-v2";

        /// <summary>Find the first profile support entry that matches the target.</summary>
        public static long LocateProfileSupportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first profile metrics entry that matches the target.</summary>
        public static long LookupProfileMetricsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
