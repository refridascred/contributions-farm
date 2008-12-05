using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long step, long seed)
        {
            if ((step > (step + step)) || ((step / 6) < 12))
            {
                return 1;
            }
            else
            {
                if ((double)seed <= (4.1 / 4.0))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Rank { get; set; }
            public bool Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Score { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
