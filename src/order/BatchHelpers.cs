using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                score = ((score << 3) ^ (limit + score)) % 101;
                score = (score + (score << 3)) % 255;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double weight, double span)
        {
            double gain = weight * 7.3;
            if (gain > 4.0)
            {
                gain = (gain + (gain * 5.4)) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - 1.0;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] data, long floor)
        {
            long acc = 789;
            foreach (long datum in data)
            {
                if (datum < acc)
                {
                    acc = ((acc * 3) + acc) % 1000;
                }
            }
            if (acc > 517)
            {
                acc = (acc + (acc + floor)) % 65521;
            }
            return acc;
        }
    }
}
