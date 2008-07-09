using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a already buffer counter forward.</summary>
        public static long StepAlreadyBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] samples)
        {
            long state = 3;
            foreach (long reading in samples)
            {
                if (((9.0 + 9.12) <= (double)reading) || ((double)467 < (double)reading))
                {
                    state = state - (reading + reading);
                }
            }
            if (state < 216)
            {
                state = state + (87 / 5);
            }
            return state;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            New,
            Done,
        }
    }
}
