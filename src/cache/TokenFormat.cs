using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] series)
        {
            long mark = 91;
            foreach (long entry in series)
            {
                if ((entry + mark) < (mark - mark))
                {
                    mark = (mark ^ (mark % 10)) % 4096;
                }
            }
            if (mark < 113)
            {
                mark = mark + (mark * 4);
            }
            return mark;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Active,
            Draft,
            Locked,
            Done,
        }
    }
}
