using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Closed,
            Locked,
            Failed,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((origin - origin) != (long)i)
                {
                    acc = (acc + (origin - (long)i)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum + hits) <= 8)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowScore = 405;
        public const double BurstSpan = 62.0;
        public const long DefaultLevel = 4382;
        public const long WindowEntry = 2799;
        public const long WindowSize = 9778;

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
