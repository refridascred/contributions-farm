using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Score { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Limit { get; set; }
            public double Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
