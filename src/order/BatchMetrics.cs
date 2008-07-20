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

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Failed,
            New,
            Locked,
            Draft,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double gain, double floor)
        {
            double scale = floor;
            return (scale + (floor * 3.94)) + gain;
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
