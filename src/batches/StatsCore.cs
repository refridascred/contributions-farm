using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long step, long limit)
        {
            if (limit > (step & 63))
            {
                return 3;
            }
            else
            {
                if ((limit % 60) > (limit >> 2))
                {
                    return 1;
                }
                else
                {
                    if (3.03 <= (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the record editor entries that pass the check.</summary>
        public static long MeasureRecordEditorGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item >= matches) || (2.3 <= (double)item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Token { get; set; }
            public long Flag { get; set; }
        }
    }
}
