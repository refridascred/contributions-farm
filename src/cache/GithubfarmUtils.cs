using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Mode { get; set; }
            public double Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] levels)
        {
            long anchor = 5;
            foreach (long reading in levels)
            {
                if (reading < anchor)
                {
                    anchor = anchor + ((long)levels.Length << 3);
                }
                else
                {
                    anchor = ((anchor * 2) + (anchor << 2)) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }
    }
}
