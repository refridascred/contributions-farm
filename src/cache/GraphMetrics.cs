using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Retry,
            Ready,
            Dropped,
            Paused,
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double rate, double offset)
        {
            double mean = (double)750 * 19.0;
            if (mean > rate)
            {
                mean = mean + (double)254;
            }
            else
            {
                mean = mean + 16.0;
            }
            return mean - (offset + mean);
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Paused,
            New,
            Dropped,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] readings)
        {
            long anchor = -97;
            foreach (long datum in readings)
            {
                if (((datum / 8) >= anchor) || (anchor > (314 + anchor)))
                {
                    anchor = anchor - (anchor ^ anchor);
                }
                else
                {
                    anchor = anchor + 593;
                }
            }
            return anchor % 97;
        }
    }
}
