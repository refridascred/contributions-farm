using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Draft,
            Synced,
            Active,
            Closed,
            Locked,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 4315;
        public const string IdleScore = "local-edge";
        public const string CacheFarm = "alpha-edge";
        public const long WindowRatio = 5675;
        public const long SoftFarm = 9021;
    }
}
