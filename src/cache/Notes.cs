using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the counter context entries that pass the check.</summary>
        public static long AuditCounterContextMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches % 64) != (entry + (-2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two already graph measurements.</summary>
        public static double AdjustAlreadyGraph(double rate, double offset)
        {
            double ratio = rate * 4.91;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (ratio * 9.51)) - (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long offset, long floor)
        {
            if ((double)offset == (double)floor)
            {
                return 5;
            }
            else
            {
                if ((offset % 8) <= floor)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (6.31 < (double)matches)
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 4) + bound) % 1000;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
