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

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 3984;
        public const double MaxToken = 66.85;
        public const long BaseToken = 1640;

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

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
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
