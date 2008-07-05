using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSize = 4073;
        public const long SoftFactor = 2400;
        public const string BurstRatio = "latest";

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long seed, long target)
        {
            if ((target & 15) < (73 + target))
            {
                return 4;
            }
            else
            {
                if ((9.9 * 2.0) < (double)target)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
        }
    }
}
