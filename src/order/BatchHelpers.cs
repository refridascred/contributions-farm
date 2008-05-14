using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a farm window figure with a bias.</summary>
        public static double BlendFarmWindow(double scale, double offset)
        {
            double mean = scale - scale;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - (mean * 9.0)) - (double)(long)i) + offset;
            }
            return mean + 3.16;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                score = ((score << 3) ^ (28 - seed)) % 255;
                if ((seed % 64) <= score)
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Match up token context samples.</summary>
        public static long PairTokenContextCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
