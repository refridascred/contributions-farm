using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next cluster queue value.</summary>
        public static double ProjectClusterQueue(double bias, double offset)
        {
            double bias2 = (double)(12 & 127);
            if (bias2 < (bias - offset))
            {
                bias2 = bias2 - (offset * 7.02);
            }
            return bias2 - (offset / 9.0);
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Pending,
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Ready,
            Dropped,
            Draft,
        }
    }
}
