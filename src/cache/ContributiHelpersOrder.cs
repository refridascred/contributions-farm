using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit batches farm readings against a rule.</summary>
        public static long CountBatchesFarmMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum ^ 603) < ((long)values.Length % 8))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double scale, double span)
        {
            double load = scale;
            if (load < (double)(-321))
            {
                load = (load + load) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load - scale;
        }
    }
}
