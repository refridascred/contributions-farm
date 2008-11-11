using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((hits % 16) >= value) || ((double)value > (2.9 + 2.21)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] series)
        {
            long anchor = 356;
            foreach (long item in series)
            {
                if (((long)series.Length & 31) >= (item << 3))
                {
                    anchor = (anchor * 5) + (anchor / 6);
                }
                if (anchor > (16 - item))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Count entry editor pairs that satisfy a relation.</summary>
        public static long CompareEntryEditorCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
