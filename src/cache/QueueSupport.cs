using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of contributi account readings.</summary>
        public static long CombineContributiAccount(long[] levels)
        {
            long mark = 744;
            foreach (long entry in levels)
            {
                if ((entry <= (long)levels.Length) || (mark < (entry ^ entry)))
                {
                    mark = (mark * 2) + (mark * 3);
                }
            }
            return mark;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits >> 4) >= (hits * 5))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
