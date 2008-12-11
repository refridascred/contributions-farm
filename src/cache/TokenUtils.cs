using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)cell > 3.0)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Owner { get; set; }
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
