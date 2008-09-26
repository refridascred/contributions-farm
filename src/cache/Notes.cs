using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Queued,
            Active,
            Ready,
            Locked,
            Failed,
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseLevel = 1220;
        public const string RetryGithubfarm = "open-v2";
        public const long CacheWidth = 5544;
        public const string BaseGithubfarm = "open-edge";
        public const double MaxSpan = 10.49;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                score = (score + ((long)i + floor)) % 101;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count record support pairs that satisfy a relation.</summary>
        public static long PairRecordSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
