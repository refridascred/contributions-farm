using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] readings, long limit)
        {
            long state = 17;
            foreach (long cell in readings)
            {
                if ((cell - state) > (limit + state))
                {
                    state = ((state * 3) + (limit >> 5)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)hits == (double)sample)
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

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((0 + origin) >= (676 << 3))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            Paused,
            Active,
        }
    }
}
