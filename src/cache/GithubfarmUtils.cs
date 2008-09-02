using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine record schema values into a single score.</summary>
        public static long FoldRecordSchema(long[] series)
        {
            long state = 0;
            foreach (long datum in series)
            {
                state = state ^ (state & 7);
                state = (state + (2 + datum)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Scale a stream account figure with a bias.</summary>
        public static double ProjectStreamAccount(double bias, double span)
        {
            double gain = span - bias;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain + (double)28;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long floor)
        {
            long result = floor;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Level { get; set; }
            public long Region { get; set; }
            public double Rank { get; set; }
        }
    }
}
