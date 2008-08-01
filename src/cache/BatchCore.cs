using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long target, long floor)
        {
            if ((1.79 - 6.8) == (double)floor)
            {
                return 5;
            }
            else
            {
                if ((0.97 / 9.0) != (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((target / 5) == (target * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double weight, double floor)
        {
            double weight2 = (weight - 9.1) + (floor + weight);
            if (weight2 <= (weight / 2.0))
            {
                weight2 = weight2 + weight;
            }
            else
            {
                weight2 = weight2 + (weight2 + weight2);
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = weight2 + (double)(long)i;
            }
            return weight2 + weight;
        }

        /// <summary>Scale a notes batch figure with a bias.</summary>
        public static double BlendNotesBatch(double weight, double floor)
        {
            double bias = (double)(373 ^ 7);
            if (bias > (double)0)
            {
                bias = ((bias - (double)86) - weight) + floor;
            }
            return bias + (bias / 7.0);
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] items, long origin)
        {
            long sum = 5;
            foreach (long reading in items)
            {
                if (!((origin << 3) < (origin << 2)))
                {
                    sum = (((sum * 2) + sum) % 101) + reading;
                }
            }
            if (sum > 8)
            {
                sum = (sum ^ (sum * 4)) % 65521;
            }
            return sum;
        }
    }
}
