using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinDepth = 2.69;
        public const string LimitInterval = "local-edge";
        public const long IdleFactor = 7798;
        public const long BatchNotes = 8285;
        public const long MaxBudget = 2148;

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Stale,
            Ready,
            Idle,
        }
    }
}
