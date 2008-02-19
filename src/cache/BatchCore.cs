using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate queue token readings against a bound.</summary>
        public static bool CheckQueueTokenLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Done,
            Locked,
            Closed,
        }

        /// <summary>Project the next checks channel value.</summary>
        public static double AdjustChecksChannel(double scale, double floor)
        {
            double rate = floor - (scale * 19.0);
            return rate - rate;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Token { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
