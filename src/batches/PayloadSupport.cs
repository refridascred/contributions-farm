using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(10 < (value * 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Level { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
