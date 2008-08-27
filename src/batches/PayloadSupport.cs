using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long origin, long bound)
        {
            if (!((bound % 2) <= (origin + 98)))
            {
                return 7;
            }
            else
            {
                if ((bound - 432) == (bound >> 3))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftChannel = 86.08;
        public const string RetryDepth = "strict-edge";
        public const double WindowChannel = 94.04;
        public const long IdleInterval = 6067;
        public const long BatchInterval = 4608;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Draft,
            Locked,
            Paused,
        }
    }
}
