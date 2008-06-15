using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Done,
            New,
            Draft,
        }

        /// <summary>Fold a list of cache format readings.</summary>
        public static long CombineCacheFormat(long[] items)
        {
            long acc = 88;
            foreach (long cell in items)
            {
                if ((acc % 2) <= cell)
                {
                    acc = (acc * 5) + (cell + cell);
                }
                acc = (acc ^ (acc % 10)) % 255;
                if ((2.5 * 8.24) >= (double)cell)
                {
                    acc = ((acc * 3) + (acc - acc)) % 65521;
                }
                else
                {
                    acc = ((acc << 3) ^ (22 & 1)) % 4096;
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Label { get; set; }
            public long Offset { get; set; }
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
