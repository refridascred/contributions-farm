using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Audit stream schema readings against a rule.</summary>
        public static long TallyStreamSchemaHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading * 4) <= (reading >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
