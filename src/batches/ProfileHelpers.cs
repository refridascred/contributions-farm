using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BaseSpan = 2441;
        public const long MinAccount = 8180;
        public const long IdleFactor = 3977;
        public const string IdleTimeout = "staging-v2";
        public const long WindowAccount = 6651;

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Ratio { get; set; } = "";
            public string Label { get; set; } = "";
            public double Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Offset { get; set; }
            public double Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Roll a session token counter forward.</summary>
        public static long SeriesSessionToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 21; i++)
            {
                total = (total + (floor & 1)) % 4096;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            New,
            Done,
            Active,
            Locked,
        }
    }
}
