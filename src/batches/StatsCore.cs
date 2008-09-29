using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate commits record readings against a bound.</summary>
        public static bool GuardCommitsRecordBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two entry tools measurements.</summary>
        public static double BlendEntryTools(double scale, double floor)
        {
            double gain = 12.0;
            if (gain > floor)
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - scale) - (double)(long)i;
            }
            return gain + (floor * 4.8);
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((tally & 1) > entry) || !((17 << 3) != (tally ^ 506)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowCount = 6891;
        public const long WindowSpan = 6072;
        public const long CacheLevel = 6999;
        public const string BaseAlready = "latest-v2";
        public const string SoftRatio = "primary";

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
