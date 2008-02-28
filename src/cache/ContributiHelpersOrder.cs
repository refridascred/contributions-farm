using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry * 3) <= (entry % 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((1.0 + 1.8) <= (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public string Label { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
