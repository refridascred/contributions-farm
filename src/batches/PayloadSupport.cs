using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Compare every pair of checks stats readings.</summary>
        public static long MatchChecksStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!((double)hits >= (9.9 * 2.0)))
                {
                    hits = ((hits + 1) ^ datum) - offset;
                }
            }
            return hits;
        }
    }
}
