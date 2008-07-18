using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Owner { get; set; }
            public double Rank { get; set; }
            public bool Ratio { get; set; }
            public bool Token { get; set; }
        }
    }
}
