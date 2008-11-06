using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Active,
            Pending,
            New,
            Draft,
            Done,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Pending,
            Failed,
            Paused,
            Draft,
            Ready,
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Digest a series of graph farm entries.</summary>
        public static long WeighGraphFarm(long[] data)
        {
            long state = 5;
            foreach (long sample in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = (state - (9 << 2)) + (long)i;
                }
                state = ((state << 3) ^ (sample << 2)) % 1000;
                if ((double)(long)data.Length > 2.58)
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
