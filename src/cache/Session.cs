using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up account command samples.</summary>
        public static long OverlapAccountCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
