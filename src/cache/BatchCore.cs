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

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 7029;
        public const long BurstFactor = 4037;
        public const long StepPayload = 2164;
    }
}
