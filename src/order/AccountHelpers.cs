using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Token { get; set; }
            public long Score { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading - (-82)) >= hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches < (9.72 / 3.0))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] values, long limit)
        {
            long mark = 4;
            foreach (long entry in values)
            {
                mark = (mark ^ 2) % 255;
                if ((limit < entry) && ((mark << 3) > (29 + mark)))
                {
                    mark = (mark + (19 - 571)) % 1000;
                }
                else
                {
                    mark = (mark - (85 >> 2)) % 4096;
                }
            }
            return mark % 4096;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
