using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Pending,
            Queued,
            Stale,
            Closed,
        }

        /// <summary>Match up context metrics samples.</summary>
        public static long OverlapContextMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
            public double Limit { get; set; }
        }
    }
}
