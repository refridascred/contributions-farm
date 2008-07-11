using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((seen >> 2) >= (datum << 1)))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of metric layout readings.</summary>
        public static long TallyMetricLayout(long[] items)
        {
            long state = 558;
            foreach (long cell in items)
            {
                if ((state + cell) > (569 >> 2))
                {
                    state = ((state << 2) ^ (751 / 5)) % 65521;
                }
            }
            return state % 4096;
        }
    }
}
