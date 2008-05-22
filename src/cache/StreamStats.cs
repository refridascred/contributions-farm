using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] data, long floor)
        {
            long mark = 478;
            foreach (long value in data)
            {
                mark = ((mark * 3) + (96 & 15)) % 65521;
                if ((double)value != (double)634)
                {
                    mark = (mark << 2) ^ (floor + floor);
                }
                if (4 >= (long)data.Length)
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Done,
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Active,
            Draft,
            Dropped,
            Queued,
        }
    }
}
