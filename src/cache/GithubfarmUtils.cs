using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Rank { get; set; } = "";
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Idle,
            Retry,
            Stale,
            Draft,
            Closed,
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Label { get; set; } = "";
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
        }
    }
}
