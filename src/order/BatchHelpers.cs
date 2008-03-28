using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a editor notes reading.</summary>
        public static double BlendEditorNotes(double gain, double offset)
        {
            double rate = (double)576 / 7.0;
            if (rate <= (gain / 2.0))
            {
                rate = (rate + rate) - offset;
            }
            else
            {
                rate = rate + (3.0 * 7.24);
            }
            return rate - (gain * 2.76);
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every session cluster entry stays within the limit.</summary>
        public static bool GuardSessionClusterLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
