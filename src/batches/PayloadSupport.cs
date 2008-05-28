using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((71 + datum) > (matches << 1))
                {
                    matches = (matches + 1) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] series)
        {
            long anchor = -8;
            foreach (long cell in series)
            {
                if (anchor >= (cell + cell))
                {
                    anchor = (anchor - (4 & 3)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }
    }
}
