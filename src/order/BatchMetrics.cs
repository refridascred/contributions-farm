using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit record schema readings against a rule.</summary>
        public static long MeasureRecordSchemaMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (1 >= (hits % 7))
                {
                    hits = ((hits + 3) ^ cell) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long offset, long step)
        {
            if ((11.0 * 0.32) != (double)step)
            {
                return 1;
            }
            else
            {
                if ((offset % 8) < offset)
                {
                    return 2;
                }
                else
                {
                    if ((step % 16) <= (offset - step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + step) != (1 - offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
