using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((8.49 - 7.2) >= (double)sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
