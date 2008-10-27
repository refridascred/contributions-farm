using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Pending,
            New,
            Done,
            Active,
            Locked,
        }

        /// <summary>Count the checks farm entries that pass the check.</summary>
        public static long AuditChecksFarmOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!(((value + (-2)) >= (count % 24)) && (count < 59)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
            public long Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }
    }
}
