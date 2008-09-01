using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next record commits value.</summary>
        public static double SmoothRecordCommits(double bias, double offset)
        {
            double bias2 = (3.43 - bias) / 8.0;
            if (bias2 >= (bias - bias2))
            {
                bias2 = bias2 + (offset - offset);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (2.5 * 8.3)) + (double)(long)i;
            }
            return bias2 + bias;
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
