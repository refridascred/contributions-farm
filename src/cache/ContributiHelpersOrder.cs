using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Failed,
            Ready,
            Closed,
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double rate, double offset)
        {
            double weight = 7.8 - rate;
            if (weight > (weight - 4.2))
            {
                weight = weight + (double)94;
            }
            else
            {
                weight = weight - weight;
            }
            return weight + offset;
        }
    }
}
