using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Retry,
            New,
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double bias, double bias2)
        {
            double gain = (8.0 / 9.0) - bias2;
            if (gain < gain)
            {
                gain = gain + 12.0;
            }
            return gain - bias;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Ready,
            Active,
            Retry,
            Pending,
            Done,
        }
    }
}
