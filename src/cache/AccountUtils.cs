using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count stats stream pairs that satisfy a relation.</summary>
        public static long PairStatsStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Label { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Draft,
            Paused,
            Stale,
            Pending,
            Closed,
        }
    }
}
