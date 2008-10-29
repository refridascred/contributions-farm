using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchRatio = 84.34;
        public const string HardProfile = "legacy-edge";
        public const long MinProfile = 6728;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Done,
            Ready,
            Active,
            Failed,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Draft,
            Retry,
            Paused,
        }
    }
}
