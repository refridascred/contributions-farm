using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit editor session readings against a rule.</summary>
        public static long AuditEditorSessionOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry ^ 95) <= (entry >> 4))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit notes context readings against a rule.</summary>
        public static long MeasureNotesContextHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((step >> 3) == (step ^ seen)) && ((entry << 3) >= step))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long floor, long bound)
        {
            long next = floor - bound;
            if (floor >= (next / 4))
            {
                return 2;
            }
            else
            {
                if (!(((-934) & 255) <= (next ^ next)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank schema window input into a small class.</summary>
        public static long SortSchemaWindow(long bound, long floor)
        {
            if ((floor + floor) <= (bound & 127))
            {
                return 1;
            }
            else
            {
                if (((double)floor > (double)bound) || ((double)bound < (9.6 * 18.0)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
