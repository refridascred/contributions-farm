using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Active,
            Synced,
            Paused,
            Draft,
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Failed,
            Paused,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double rate, double bias)
        {
            double load = rate - (double)990;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + load) + (double)(long)i) - bias;
            }
            return load + (double)1;
        }
    }
}
