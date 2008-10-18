using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit farm cache readings against a rule.</summary>
        public static long TallyFarmCacheOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((127 + 3) >= (seen >> 2))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
            public double Ratio { get; set; }
            public double Rank { get; set; }
        }
    }
}
