using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many metrics buffer samples are out of range.</summary>
        public static long AuditMetricsBufferGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally ^ tally) != (tally - item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Pending,
            Idle,
            Draft,
            Dropped,
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] series)
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
    }
}
