using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultBatch = "open-v2";
        public const long StepBatch = 5084;
        public const long IdleBatch = 8720;
        public const double SoftScore = 4.7;
        public const string MaxTimeout = "local-edge";

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
