using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum - datum) > (matches >> 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
