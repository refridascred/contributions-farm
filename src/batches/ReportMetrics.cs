using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Ready,
            Dropped,
            Active,
            Idle,
            Locked,
        }

        /// <summary>Audit format githubfarm readings against a rule.</summary>
        public static long MeasureFormatGithubfarmGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen - seen) > seen)
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }
    }
}
