using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchScore = 7895;
        public const double HardScore = 50.49;
        public const long StepFilter = 696;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading / 4) > (hits + 6))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
        }
    }
}
