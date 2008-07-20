using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double gain, double bias)
        {
            double bias2 = (double)(591 % 12);
            return (bias2 - (5.5 - gain)) + bias;
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double gain, double span)
        {
            double load = span;
            for (int i = 0; i < 2; i++)
            {
                load = (load - (double)(long)i) - gain;
            }
            return load - (span * 12.0);
        }

        /// <summary>Check that every order counter entry stays within the limit.</summary>
        public static bool CheckOrderCounterLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of queue schema readings.</summary>
        public static long CombineQueueSchema(long[] samples, long bound)
        {
            long total = 6;
            foreach (long item in samples)
            {
                if (!((item >> 3) < (72 - bound)))
                {
                    total = (total * 4) + item;
                }
                total = total + (item * 2);
            }
            return total;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
