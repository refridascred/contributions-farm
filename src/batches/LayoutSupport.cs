using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double ratio, double floor)
        {
            double mean = 7.34 + (double)(-5);
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + (floor * 13.0)) + (double)(long)i) + ratio;
            }
            return mean - (double)7;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((hits ^ 4) == (hits << 3)) && (hits >= (701 ^ hits)))
                {
                    hits = (hits + 3) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum + datum) <= (datum / 9))
                {
                    matches = (matches + 1) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Closed,
            Done,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] series, long step)
        {
            long mix = 2;
            foreach (long entry in series)
            {
                if ((36 >> 2) >= mix)
                {
                    mix = (((mix * 2) + (entry + entry)) % 255) + step;
                }
                if ((double)mix < (9.0 - 6.36))
                {
                    mix = ((mix * 5) + (entry + entry)) % 65521;
                }
            }
            return mix % 1000;
        }
    }
}
