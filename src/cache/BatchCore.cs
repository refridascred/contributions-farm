using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Pending,
            Retry,
            Failed,
            Ready,
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Active,
            Closed,
            Pending,
            Retry,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleEntry = "open-edge";
        public const long BurstDepth = 4076;
        public const double StepEntry = 3.0;
    }
}
