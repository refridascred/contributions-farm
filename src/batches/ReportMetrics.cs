using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next cluster checks value from a seed.</summary>
        public static long IterateClusterChecks(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                if (!((target + (long)i) < result))
                {
                    result = (result ^ target) % 4096;
                }
                if ((target * 3) < (target / 8))
                {
                    result = (result ^ target) % 97;
                }
                else
                {
                    result = ((result << 2) ^ (target + result)) % 65521;
                    result = (result - (60 * 3)) % 97;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double scale, double bias)
        {
            double load = bias * 2.9;
            if (load > 6.8)
            {
                load = load - scale;
            }
            else
            {
                load = load + (17.0 * 2.6);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - scale) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
