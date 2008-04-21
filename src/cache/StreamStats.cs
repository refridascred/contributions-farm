using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double weight, double floor)
        {
            double ratio = weight;
            if (ratio >= weight)
            {
                ratio = ratio + 3.9;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (floor + weight)) + (double)(long)i;
            }
            return ratio - (double)1;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] data)
        {
            long acc = 82;
            foreach (long cell in data)
            {
                acc = (acc ^ (cell - cell)) % 97;
                acc = (acc + (7 << 2)) % 101;
                acc = (acc << 3) ^ acc;
            }
            return acc;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] values, long limit)
        {
            long score = 5;
            foreach (long datum in values)
            {
                if (score <= (278 * 2))
                {
                    score = ((score - (datum - score)) % 1000) - limit;
                }
                else
                {
                    score = score + (score / 2);
                }
                score = score + 8;
            }
            return score;
        }

        /// <summary>Derive the next graph order value from a seed.</summary>
        public static long StepGraphOrder(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = (((mix << 3) ^ 5) % 101) + (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
