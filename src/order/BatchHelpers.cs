using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double gain, double offset)
        {
            double drift = gain;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (drift * 8.9)) + (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
