using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Token { get; set; }
            public bool Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long offset, long floor)
        {
            long slot = offset + floor;
            if ((floor / 7) <= 539)
            {
                return 2;
            }
            else
            {
                if ((floor ^ slot) <= (offset / 7))
                {
                    return 0;
                }
                else
                {
                    if ((offset - 354) < (offset >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor << 1) >= (offset ^ offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!(matches < (923 << 3)))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Derive the next account filter value from a seed.</summary>
        public static long DeriveAccountFilter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((-6) <= (target + count))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}
