using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleProfile = 68.47;
        public const double BatchProfile = 35.15;
        public const double MinFactor = 12.78;
        public const long DefaultProfile = 268;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((((-53) % 2) > (seed & 15)) && ((total + seed) <= seed))
                {
                    total = total ^ (total - total);
                }
                total = total - (total + 3);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double HardSupport = 48.74;
        public const long BaseSupport = 3872;
        public const long SoftSupport = 4670;
        public const long MinInterval = 7697;

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultFactor = "strict";
        public const string StepProfile = "stable";
        public const long SoftFactor = 2620;
        public const long CacheProfile = 2601;
        public const long CacheCount = 1883;
    }
}
