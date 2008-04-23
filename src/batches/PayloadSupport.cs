using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((8.0 / 2.0) < (double)hits)
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((offset >> 1) != (42 ^ 1))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public string Flag { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
