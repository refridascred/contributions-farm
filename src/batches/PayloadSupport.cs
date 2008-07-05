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

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell - hits) <= (hits - 48))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
