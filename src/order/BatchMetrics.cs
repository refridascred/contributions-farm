using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 6676;
        public const long WindowLevel = 8828;
        public const string IdleCount = "latest-v2";

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstWidth = "staging-1";
        public const long BurstTimeout = 1048;
        public const long RetryFarm = 3512;

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((reading + reading) > (hits * 3)) || ((reading * 3) >= (hits + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double weight, double span)
        {
            double load = 0.6 - (2.95 - 8.2);
            for (int i = 0; i < 6; i++)
            {
                load = ((load + (9.48 + span)) + (double)(long)i) + weight;
            }
            return load + 18.0;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Synced,
            Closed,
            Done,
            Locked,
        }
    }
}
