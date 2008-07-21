using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Queued,
            Locked,
            Ready,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Level { get; set; } = "";
            public double Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of payload checks readings.</summary>
        public static long OverlapPayloadChecksCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Pending,
            Locked,
            Active,
        }
    }
}
