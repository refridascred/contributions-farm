using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] samples)
        {
            long mark = 6;
            foreach (long datum in samples)
            {
                mark = ((mark - mark) % 65521) + datum;
            }
            if (mark < 2)
            {
                mark = (mark - (mark / 3)) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 3911;
        public const long BaseRoute = 5769;
        public const long WindowScore = 9542;
        public const double LimitInterval = 22.31;
        public const long DefaultRoute = 3028;
    }
}
