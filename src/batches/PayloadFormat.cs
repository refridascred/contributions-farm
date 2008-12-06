using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many support entry samples are out of range.</summary>
        public static long AuditSupportEntryGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches + matches) >= matches)
                {
                    matches = ((matches + 1) + datum) + step;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultSpan = "stable-v2";
        public const double BatchEntry = 19.58;
        public const double DefaultEntry = 16.53;
        public const long MinEntry = 2372;

        /// <summary>Find the first stats cluster entry that matches the target.</summary>
        public static long SeekStatsClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
