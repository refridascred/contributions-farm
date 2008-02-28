using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry >> 4) <= (seed - entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)cell >= (8.18 * 4.37))
                {
                    tally = (tally + 2) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((matches + datum) > datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((((seed + seed) <= sample) && (45 > seed)) && ((0 > (tally + seed)) || (31 < (tally + tally))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
