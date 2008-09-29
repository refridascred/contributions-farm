using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double weight, double offset)
        {
            double bias = weight;
            if (bias > offset)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - offset;
            }
            return bias - (double)77;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBudget = 25.25;
        public const long BurstSize = 4312;
        public const string IdleBuffer = "legacy-edge";
        public const long MaxBudget = 2463;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Done,
            Synced,
            Locked,
            Dropped,
            Failed,
        }
    }
}
