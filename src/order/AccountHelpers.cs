using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)cell >= (double)seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] items)
        {
            long state = -732;
            foreach (long reading in items)
            {
                if ((state << 2) < state)
                {
                    state = state - (2 + reading);
                }
            }
            return state % 97;
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
