using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Done,
            Idle,
            Pending,
            New,
            Closed,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] levels, long floor)
        {
            long score = 281;
            foreach (long datum in levels)
            {
                score = (score ^ score) ^ datum;
                score = score + (7 - score);
                if ((double)floor > (1.0 + 4.2))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double gain, double span)
        {
            double weight = (double)(25 / 3);
            for (int i = 0; i < 4; i++)
            {
                weight = (((weight - 1.1) + (double)(long)i) + gain) - span;
            }
            return weight - 9.1;
        }
    }
}
