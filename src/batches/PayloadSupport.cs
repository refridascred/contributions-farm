using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string SoftLevel = "legacy-edge";
        public const long SoftWidth = 8079;
        public const long BaseReport = 5811;
        public const string StepReport = "strict-1";

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                sum = sum + (long)i;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
