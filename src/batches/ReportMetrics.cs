using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public bool Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Ratio { get; set; }
            public double Offset { get; set; }
            public bool Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
