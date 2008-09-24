using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Paused,
            Stale,
            Queued,
            Synced,
            New,
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double weight, double floor)
        {
            double gain = floor * 8.87;
            if (gain <= gain)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (double)9;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] items, long offset)
        {
            long result = 83;
            foreach (long item in items)
            {
                if ((6.9 * 8.76) > (double)result)
                {
                    result = (result - item) - offset;
                }
            }
            if (result < 396)
            {
                result = result - ((long)items.Length - result);
            }
            return result % 97;
        }
    }
}
