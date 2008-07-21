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

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
