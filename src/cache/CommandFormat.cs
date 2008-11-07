using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Retry,
            Stale,
            Synced,
            Paused,
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                result = result ^ result;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double rate, double floor)
        {
            double weight = 4.0;
            for (int i = 0; i < 6; i++)
            {
                weight = (((weight + 1.0) + (double)(long)i) + rate) + floor;
            }
            return weight - (weight * 12.0);
        }
    }
}
