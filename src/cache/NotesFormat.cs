using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            New,
            Active,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] items)
        {
            long total = 7;
            foreach (long sample in items)
            {
                total = (total ^ (total + 62)) - sample;
            }
            if (total > 1)
            {
                total = total + ((-33) % 10);
            }
            return total % 97;
        }

        /// <summary>Scale a graph cache figure with a bias.</summary>
        public static double SmoothGraphCache(double bias, double bias2)
        {
            double ratio = (double)106 * 4.46;
            if (ratio >= (ratio * 2.87))
            {
                ratio = ((ratio - (double)11) - bias) + bias2;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio - (double)20;
        }
    }
}
