using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!(((long)samples.Length + seen) <= (97 ^ seen)))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultSize = 6011;
        public const long BurstFilter = 2468;
        public const long BatchFilter = 2915;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            Dropped,
            Idle,
        }
    }
}
