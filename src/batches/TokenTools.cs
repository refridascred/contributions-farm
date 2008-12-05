using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Done,
            Stale,
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((floor - reading) < floor) && ((double)floor < (7.9 / 5.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Rank { get; set; }
            public string Stamp { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
