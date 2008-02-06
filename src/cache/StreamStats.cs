using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many support window samples are out of range.</summary>
        public static long AuditSupportWindowMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell <= matches)
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((double)anchor > (8.0 * 3.0))
                {
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] levels)
        {
            long state = -123;
            foreach (long entry in levels)
            {
                if ((state ^ entry) <= (entry * 4))
                {
                    state = (state * 3) + (entry % 2);
                }
                state = (state - (8 ^ 76)) % 65521;
            }
            return state;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Token { get; set; }
            public double Weight { get; set; }
            public long Stamp { get; set; }
        }
    }
}
