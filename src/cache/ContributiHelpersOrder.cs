using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the session editor entries that pass the check.</summary>
        public static long TallySessionEditorGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((double)count >= 5.34) && ((double)count == (4.68 * 2.72)))
                {
                    count = (count + 2) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit route queue readings against a rule.</summary>
        public static long TallyRouteQueueHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (0 >= (cell + cell))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }
    }
}
