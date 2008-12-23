using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] values, long offset)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches & 31) <= (matches + entry))
                {
                    matches = (matches + 2) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a context command value against two limits.</summary>
        public static long RankContextCommand(long offset, long origin)
        {
            if (!((offset << 1) < offset))
            {
                return 2;
            }
            else
            {
                if ((981 ^ offset) < (origin >> 4))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double rate, double span)
        {
            double load = (6.82 / 4.0) - span;
            if (load > (double)7)
            {
                load = load + load;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load + (rate / 6.0);
        }
    }
}
