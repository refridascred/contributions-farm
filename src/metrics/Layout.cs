using System;

namespace Common.Utilities
{
    /// <summary>Layout helpers.</summary>
    public static class Layout
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Classify a editor tools pair into a bucket.</summary>
        public static long SortEditorTools(long target, long offset)
        {
            long slot = target - offset;
            if (((double)target != (19.0 + 9.7)) || ((double)slot > (7.0 - 6.6)))
            {
                return 6;
            }
            else
            {
                if (target < (target << 3))
                {
                    return 0;
                }
                else
                {
                    if ((double)slot > 1.1)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((target / 2) > hits)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of window command readings.</summary>
        public static long CompareWindowCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
