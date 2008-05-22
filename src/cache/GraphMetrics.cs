using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((count - count) > (value - value)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((876 + matches) >= 15) && (sample >= (sample * 2)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public string Total { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Region { get; set; }
            public bool Token { get; set; }
            public long Level { get; set; }
        }
    }
}
