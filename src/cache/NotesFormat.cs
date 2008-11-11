using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double ratio, double bias)
        {
            double ratio2 = (ratio - 17.0) - (bias + 6.23);
            return ratio2 - (ratio2 - ratio);
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double bias, double bias2)
        {
            double weight = bias2;
            if (weight >= (bias2 * 9.0))
            {
                weight = (weight - (double)54) + bias;
            }
            return weight + bias2;
        }
    }
}
