using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Locked,
            Idle,
            Draft,
            Pending,
            Ready,
        }

        /// <summary>Adjust a filter channel reading.</summary>
        public static double ProjectFilterChannel(double gain, double bias)
        {
            double ratio = (double)830 * 0.25;
            return ((ratio + (double)3) + gain) + bias;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Dropped,
            Pending,
            Ready,
        }
    }
}
