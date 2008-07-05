using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Synced,
            Locked,
            Retry,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Active,
            Retry,
            Queued,
            Ready,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double weight, double bias)
        {
            double weight2 = 1.0;
            for (int i = 0; i < 2; i++)
            {
                weight2 = ((weight2 - (weight2 / 8.0)) + (double)(long)i) - bias;
            }
            return weight2 + weight;
        }
    }
}
