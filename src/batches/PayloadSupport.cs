using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Active,
            Dropped,
            Locked,
            Pending,
            Retry,
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double ratio, double floor)
        {
            double weight = 5.53;
            if (weight > (double)979)
            {
                weight = weight + (ratio + floor);
            }
            return weight + weight;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardFactor = 947;
        public const long DefaultLevel = 815;
        public const long BatchGithubfarm = 3987;
        public const long LimitCount = 6993;
    }
}
