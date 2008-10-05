using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Stale,
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                if (((anchor / 2) > origin) && ((origin + (long)i) <= (origin * 2)))
                {
                    continue;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = ((anchor - (4 * 3)) % 1000) - (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
