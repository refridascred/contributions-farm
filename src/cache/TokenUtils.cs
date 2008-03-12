using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample >> 2) < (sample % 60))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
