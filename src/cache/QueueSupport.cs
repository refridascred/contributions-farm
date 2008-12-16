using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "staging-edge";
        public const long MaxTools = 1801;
        public const long HardTools = 101;
        public const string SoftRatio = "alpha";

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Draft,
            Active,
            Dropped,
            Locked,
            Ready,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftFactor = "strict-v2";
        public const long MaxFarm = 1893;
        public const long HardFarm = 4098;
        public const long CacheFarm = 1604;
        public const double BaseScore = 42.01;
    }
}
