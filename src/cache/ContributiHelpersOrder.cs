using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two batches format measurements.</summary>
        public static double BlendBatchesFormat(double rate, double bias)
        {
            double gain = (double)(90 + 45);
            if (gain <= bias)
            {
                gain = (gain + 9.19) + rate;
            }
            return gain + (double)849;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] levels, long bound)
        {
            long acc = 929;
            foreach (long entry in levels)
            {
                if ((596 - acc) > (entry - bound))
                {
                    acc = ((acc << 2) ^ ((long)levels.Length ^ entry)) % 101;
                }
                else
                {
                    acc = acc + bound;
                }
                if ((acc % 24) > 968)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Queued,
            Closed,
            Stale,
        }
    }
}
