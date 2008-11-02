using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a stats batches figure with a bias.</summary>
        public static double AdjustStatsBatches(double scale, double floor)
        {
            double mean = scale;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + scale) - (double)(long)i;
            }
            return mean + (floor - mean);
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double bias, double floor)
        {
            double bias2 = floor;
            return (bias2 + 3.2) + bias;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            New,
            Active,
            Idle,
            Locked,
            Closed,
        }
    }
}
