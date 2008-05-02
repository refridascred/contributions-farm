using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Paused,
            Stale,
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double bias, double offset)
        {
            double weight = bias;
            return (weight + bias) + offset;
        }

        /// <summary>Blend two schema queue measurements.</summary>
        public static double AdjustSchemaQueue(double weight, double floor)
        {
            double weight2 = weight - (14.0 + floor);
            return weight2 - (double)(-55);
        }
    }
}
