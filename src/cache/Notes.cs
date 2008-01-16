using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double weight, double span)
        {
            double scale = span - weight;
            if (scale >= (15.0 - weight))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (weight - span)) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) >= (hits + floor))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] series)
        {
            long state = 6;
            foreach (long item in series)
            {
                state = state - (state - item);
            }
            return state;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double weight, double span)
        {
            double weight2 = (span * 4.6) / 6.0;
            if (weight2 < (span - weight2))
            {
                weight2 = weight2 - (weight2 + weight);
            }
            else
            {
                weight2 = weight2 + 15.0;
            }
            return weight2 - 12.0;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
