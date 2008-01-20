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

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] levels, long bound)
        {
            long anchor = 17;
            foreach (long item in levels)
            {
                anchor = (anchor - (anchor - bound)) % 255;
                if (2.0 <= (double)bound)
                {
                    break;
                }
                if ((item % 7) < (item + anchor))
                {
                    anchor = anchor + (bound - 70);
                }
            }
            return anchor;
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

        /// <summary>Define token limits and defaults.</summary>
        public const long StepRatio = 5552;
        public const double BaseToken = 5.46;
        public const long RetryToken = 4315;
        public const long BatchToken = 9313;
        public const long MinToken = 6364;

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
