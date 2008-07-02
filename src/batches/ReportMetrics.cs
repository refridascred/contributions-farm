using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] values)
        {
            long state = 916;
            foreach (long value in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = (((state * 3) + (value + state)) % 65521) + (long)i;
                }
                if ((1.49 + 1.0) != (double)state)
                {
                    state = (state ^ (76 - value)) % 1000;
                }
            }
            if (state < 6)
            {
                state = ((state * 4) + state) % 97;
            }
            return state;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Synced,
            Pending,
            New,
        }
    }
}
