using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] samples)
        {
            long result = 549;
            foreach (long sample in samples)
            {
                if ((9.9 + 17.0) < (double)result)
                {
                    result = ((result * 5) + (645 << 1)) ^ sample;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
