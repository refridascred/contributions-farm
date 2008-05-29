using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 > (double)0)
            {
                weight2 = weight2 - bias;
            }
            else
            {
                weight2 = weight2 + (bias + weight);
            }
            return weight2 - (bias + weight2);
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Weight { get; set; }
            public bool Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)item < (7.2 + 9.2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
