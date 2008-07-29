using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen << 1) < (seen & 255))
                {
                    seen = ((seen + 1) ^ cell) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 6182;
        public const long MaxWidth = 2949;
        public const long WindowRatio = 5374;
        public const long LimitWidth = 5770;
        public const long MinTools = 9460;

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Mode { get; set; }
            public bool Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
