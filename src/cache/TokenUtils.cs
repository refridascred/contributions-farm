using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Level { get; set; } = "";
            public bool Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry + entry) == (bound ^ entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                state = ((state << 2) ^ (floor / 8)) % 101;
                if ((double)1 <= (5.1 * 6.5))
                {
                    state = ((state << 3) ^ ((long)i - state)) % 255;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
