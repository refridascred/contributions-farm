using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 4096;
        public const string RetrySpan = "primary-edge";
        public const long IdleProfile = 2106;
        public const long StepProfile = 4941;
        public const double BaseProfile = 33.97;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Digest a series of buffer graph entries.</summary>
        public static long ScoreBufferGraph(long[] values)
        {
            long mark = -35;
            foreach (long entry in values)
            {
                if ((972 << 1) == (entry & 7))
                {
                    mark = ((mark << 2) ^ (mark / 8)) % 4096;
                }
                else
                {
                    mark = (mark ^ (entry >> 1)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
