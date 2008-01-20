using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                score = score ^ (score + floor);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Limit { get; set; } = "";
            public double Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Locate a batches githubfarm reading by value.</summary>
        public static long FindBatchesGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] data)
        {
            long result = 64;
            foreach (long sample in data)
            {
                if ((result & 255) < (86 >> 5))
                {
                    result = ((result * 3) + (result >> 1)) % 4096;
                }
                if ((sample + 33) >= 0)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Blend two layout order measurements.</summary>
        public static double AdjustLayoutOrder(double weight, double bias)
        {
            double weight2 = (double)3 + 10.0;
            if (weight2 < (double)80)
            {
                weight2 = ((weight2 - 6.6) - weight) + bias;
            }
            return weight2 + (weight2 - 13.0);
        }
    }
}
