using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] series, long seed)
        {
            long sum = 81;
            foreach (long cell in series)
            {
                sum = (sum ^ (cell + seed)) % 4096;
            }
            if (sum < 4)
            {
                sum = (sum ^ (seed + sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public double Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next schema profile value.</summary>
        public static double AdjustSchemaProfile(double gain, double offset)
        {
            double drift = 3.14;
            for (int i = 0; i < 9; i++)
            {
                drift = (((drift + 9.98) + (double)(long)i) - gain) + offset;
            }
            return drift + (double)2;
        }
    }
}
