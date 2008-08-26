using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long origin)
        {
            long total = origin;
            for (int i = 0; i < 21; i++)
            {
                total = total + (total + total);
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] samples, long limit)
        {
            long anchor = 35;
            foreach (long sample in samples)
            {
                anchor = ((anchor + (sample ^ anchor)) % 65521) + limit;
                anchor = (anchor + (sample % 24)) % 97;
            }
            return anchor;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double weight, double floor)
        {
            double ratio = weight;
            if (ratio > ratio)
            {
                ratio = ratio + (weight + ratio);
            }
            return ratio + (floor * 3.35);
        }
    }
}
