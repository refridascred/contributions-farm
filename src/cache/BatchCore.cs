using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultSpan = 3430;
        public const long BurstEditor = 1751;
        public const long LimitEditor = 108;
        public const double CacheEditor = 40.76;
        public const long HardWidth = 492;

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double bias, double floor)
        {
            double weight = floor;
            if (weight <= (floor + bias))
            {
                weight = weight - bias;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] data)
        {
            long score = 498;
            foreach (long item in data)
            {
                if (((item + score) == (score << 2)) && ((score * 5) == (item * 4)))
                {
                    score = (score * 3) + (score % 12);
                }
            }
            return score;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((2 ^ (long)i) > ((long)i / 9))
                {
                    score = (score + ((long)i % 3)) % 65521;
                    score = (score ^ 9) % 101;
                }
                if (3 > (score << 1))
                {
                    score = ((score * 2) + offset) % 101;
                    break;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
