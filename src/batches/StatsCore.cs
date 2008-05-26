using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of record commits readings.</summary>
        public static long CompareRecordCommitsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinTimeout = 1913;
        public const string MaxRoute = "local-v2";
        public const long StepRoute = 4245;
        public const long BurstLevel = 1093;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((114 % 97) != (seen << 2))
                {
                    seen = (seen + 1) - item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
