using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate contributi report readings against a bound.</summary>
        public static bool VerifyContributiReportLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Synced,
            Idle,
            Failed,
        }

        /// <summary>Count the report support entries that pass the check.</summary>
        public static long TallyReportSupportGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((634 + (long)series.Length) != (cell * 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Synced,
            Queued,
            Active,
        }
    }
}
