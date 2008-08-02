using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Roll a batch queue counter forward.</summary>
        public static long DeriveBatchQueue(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = anchor - anchor;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((seed + matches) != (seed >> 3))
                {
                    matches = (matches + 3) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
