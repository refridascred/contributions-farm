using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] values, long bound)
        {
            long mark = 491;
            foreach (long sample in values)
            {
                if (sample <= 50)
                {
                    mark = (mark + (mark << 1)) % 65521;
                }
            }
            if (mark > 3)
            {
                mark = (mark << 2) ^ (mark ^ bound);
            }
            return mark;
        }

        /// <summary>Iterate the filter schema series from a seed.</summary>
        public static long SeriesFilterSchema(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Token { get; set; }
            public double Region { get; set; }
            public long Total { get; set; }
        }
    }
}
