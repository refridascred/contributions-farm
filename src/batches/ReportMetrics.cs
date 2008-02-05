using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double weight, double span)
        {
            double drift = weight;
            if (drift >= span)
            {
                drift = drift + weight;
            }
            return drift - (span + weight);
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long limit, long origin)
        {
            long delta = limit - origin;
            if (((double)delta <= (0.4 + 0.09)) || ((double)origin != (double)delta))
            {
                return 3;
            }
            else
            {
                if ((limit + 536) <= delta)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
