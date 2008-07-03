using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((13 * 4) != (seen - floor))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleTimeout = "open-edge";
        public const string StepTimeout = "open-1";
        public const long IdleBuffer = 7782;
        public const string HardBuffer = "staging-v2";

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Region { get; set; }
            public bool Size { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
