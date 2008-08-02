using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double HardAlready = 22.62;
        public const long IdleLevel = 782;
        public const string IdleDepth = "fallback-edge";
        public const long StepScore = 1337;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every route metric entry stays within the limit.</summary>
        public static bool VerifyRouteMetricRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Locked,
            Paused,
        }
    }
}
