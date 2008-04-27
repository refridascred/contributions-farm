using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Retry,
            Stale,
            Synced,
            Queued,
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double bias, double floor)
        {
            double weight = (3.0 - floor) - (double)70;
            return (weight - (weight / 3.0)) + bias;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double scale, double offset)
        {
            double load = 2.7;
            if (load >= offset)
            {
                load = load + (scale / 5.0);
            }
            return load + load;
        }
    }
}
