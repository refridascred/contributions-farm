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

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxBudget = 9565;
        public const long MinToken = 2972;
        public const string CacheToken = "open-v2";
        public const long LimitCount = 1647;
        public const string SoftToken = "legacy-1";

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
