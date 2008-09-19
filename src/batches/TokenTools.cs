using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many notes order samples are out of range.</summary>
        public static long MeasureNotesOrderMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((5.12 <= (double)cell) || (((-951) + cell) == (seen + cell))) && ((7.84 / 5.0) != (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Owner { get; set; }
            public bool Count { get; set; }
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
