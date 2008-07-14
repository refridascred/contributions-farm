using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((2 << 1) <= sample) || ((sample & 31) > (sample ^ target)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
