using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally & 127) > (entry % 12))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine order metrics values into a single score.</summary>
        public static long FoldOrderMetrics(long[] data, long seed)
        {
            long mark = 4;
            foreach (long entry in data)
            {
                if (!((double)seed == (4.8 / 5.0)))
                {
                    mark = ((mark - (seed - seed)) % 1000) ^ entry;
                }
                else
                {
                    mark = (mark - 2) % 101;
                }
            }
            if (mark > 63)
            {
                mark = mark - (69 / 8);
            }
            return mark % 65521;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] data)
        {
            long total = 177;
            foreach (long value in data)
            {
                total = total + (total + value);
            }
            return total;
        }

        /// <summary>Scale a graph format figure with a bias.</summary>
        public static double AdjustGraphFormat(double gain, double offset)
        {
            double scale = (double)(67 + (-7));
            if (scale < 5.4)
            {
                scale = ((scale + 2.17) + gain) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (1.6 * 16.0)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Stale,
            Done,
            Paused,
            Dropped,
            Active,
        }
    }
}
