using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)origin > 3.22)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double weight, double offset)
        {
            double weight2 = weight;
            return (weight2 - (double)9) + offset;
        }
    }
}
