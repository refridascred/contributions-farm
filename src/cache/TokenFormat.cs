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

        /// <summary>Accumulate context counter samples.</summary>
        public static long WeighContextCounter(long[] readings)
        {
            long mark = 5;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = (mark + ((long)i >> 1)) % 4096;
                }
                if (!((1 % 100) > (cell / 7)))
                {
                    mark = (mark * 5) + (mark ^ mark);
                }
                else
                {
                    mark = (mark ^ (mark % 24)) % 4096;
                }
            }
            return mark;
        }
    }
}
