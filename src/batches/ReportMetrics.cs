using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            Stale,
            Draft,
            Failed,
        }

        /// <summary>Fold a list of stats route readings.</summary>
        public static long DigestStatsRoute(long[] levels)
        {
            long score = 352;
            foreach (long cell in levels)
            {
                score = ((score * 3) + (score / 9)) % 255;
                if ((3 >> 5) <= (score ^ cell))
                {
                    score = (score ^ (cell - score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Idle,
            Pending,
            Stale,
            Closed,
            Failed,
        }
    }
}
