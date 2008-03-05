using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next githubfarm window value.</summary>
        public static double ProjectGithubfarmWindow(double weight, double offset)
        {
            double gain = offset - weight;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (double)6) - (double)(long)i;
            }
            return gain + 1.95;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Weight { get; set; }
            public long Label { get; set; }
            public bool Limit { get; set; }
        }
    }
}
