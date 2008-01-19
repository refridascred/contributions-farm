using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] items)
        {
            long mark = 25;
            foreach (long entry in items)
            {
                mark = (((mark * 3) + (long)items.Length) % 65521) ^ entry;
            }
            if (mark > (-5))
            {
                mark = (mark << 3) ^ (mark ^ (long)items.Length);
            }
            return mark;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 5) <= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Closed,
            Paused,
            New,
        }
    }
}
