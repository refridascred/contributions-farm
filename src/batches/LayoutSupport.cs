using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((234 >= (entry - entry)) && ((double)target >= (2.92 / 6.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((matches - matches) <= (cell - 248)) || (((cell * 3) < (38 + cell)) || ((cell >> 5) < (cell >> 4))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((2.2 - 4.1) != (double)hits))
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell < (count % 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up route stream samples.</summary>
        public static long MatchRouteStreamCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
