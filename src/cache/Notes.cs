using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support queue entries that pass the check.</summary>
        public static long AuditSupportQueueMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!(((5.0 * 8.48) != (double)tally) && (9.5 >= (double)seed)))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Closed,
            Retry,
            Paused,
            Failed,
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Count { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
