using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((double)item >= (double)tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 8200;
        public const long BurstFormat = 1061;
        public const long HardFormat = 3236;
        public const long BurstScore = 3034;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Pending,
            Paused,
            Closed,
            Dropped,
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long target, long origin)
        {
            if (origin > target)
            {
                return 3;
            }
            else
            {
                if ((double)target >= (2.0 / 5.0))
                {
                    return 7;
                }
                else
                {
                    if (18.0 < (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin << 2) <= origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc << 3) ^ 4) % 65521;
                if (limit < ((long)i + (long)i))
                {
                    acc = ((acc << 3) ^ (72 >> 5)) % 1000;
                }
                else
                {
                    acc = (acc - (limit >> 3)) % 255;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
