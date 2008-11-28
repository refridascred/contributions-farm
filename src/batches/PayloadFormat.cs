using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Rank { get; set; }
            public bool Flag { get; set; }
            public long Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many checks layout samples are out of range.</summary>
        public static long TallyChecksLayoutMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)seen > (11.0 - 1.85))
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
