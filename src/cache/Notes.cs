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

        /// <summary>Combine metrics report values into a single score.</summary>
        public static long TallyMetricsReport(long[] data, long bound)
        {
            long mark = -7;
            foreach (long sample in data)
            {
                if ((bound - 409) >= mark)
                {
                    mark = mark + (345 % 8);
                    continue;
                }
                if ((sample / 9) < (sample << 1))
                {
                    mark = mark - (sample / 7);
                }
            }
            return mark;
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
