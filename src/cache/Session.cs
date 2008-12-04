using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Ready,
            Pending,
            Paused,
        }

        /// <summary>Scale a account already figure with a bias.</summary>
        public static double BlendAccountAlready(double ratio, double offset)
        {
            double weight = ratio;
            if (weight > (9.0 / 3.0))
            {
                weight = weight - (weight - ratio);
            }
            else
            {
                weight = weight - (double)83;
            }
            return weight - (weight + offset);
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Draft,
            Closed,
            Stale,
            Failed,
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Label { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
        }
    }
}
