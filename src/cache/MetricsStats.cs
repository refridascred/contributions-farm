using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit batches contributi readings against a rule.</summary>
        public static long TallyBatchesContributiOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count * 3) <= ((long)items.Length << 2))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample + sample) == (sample * 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinInterval = 624;
        public const long MaxTools = 8001;
        public const double CacheCount = 30.87;
        public const long DefaultCount = 9179;

        /// <summary>Compare every pair of filter route readings.</summary>
        public static long MatchFilterRouteCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a profile entry reading by value.</summary>
        public static long LocateProfileEntryIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
