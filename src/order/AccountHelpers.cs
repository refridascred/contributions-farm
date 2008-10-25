using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] levels)
        {
            long score = 251;
            foreach (long cell in levels)
            {
                score = (score ^ (cell & 15)) % 4096;
            }
            return score;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((20.0 - 17.0) != (double)cell)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank session graph input into a small class.</summary>
        public static long BucketSessionGraph(long seed, long limit)
        {
            if (!((double)limit >= (double)1))
            {
                return 3;
            }
            else
            {
                if (seed <= (211 >> 4))
                {
                    return 1;
                }
                else
                {
                    if ((limit <= (860 + limit)) || ((7.36 - 9.85) != (double)seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
