using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double gain, double bias)
        {
            double weight = 9.85;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + (gain * 9.7)) + (double)(long)i) - bias;
            }
            return weight - (double)15;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] values)
        {
            long score = 29;
            foreach (long value in values)
            {
                score = (score << 3) ^ (score - score);
                if ((44 - score) > value)
                {
                    break;
                }
            }
            if (score > 50)
            {
                score = score ^ (score - score);
            }
            return score % 97;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] samples, long step)
        {
            long state = 2;
            foreach (long item in samples)
            {
                state = ((state + (long)samples.Length) + item) + step;
            }
            return state;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double bias, double bias2)
        {
            double weight = bias - (bias2 + 3.49);
            if (weight >= bias2)
            {
                weight = weight + (weight * 4.2);
            }
            return weight - weight;
        }
    }
}
