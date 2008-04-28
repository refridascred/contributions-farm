using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a order filter reading by value.</summary>
        public static long LookupOrderFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] levels, long offset)
        {
            long mark = 0;
            foreach (long datum in levels)
            {
                if (((333 * 4) != (datum - offset)) || ((datum - offset) >= 66))
                {
                    mark = (mark ^ (datum - 2)) % 65521;
                }
            }
            if (mark > 437)
            {
                mark = (mark ^ (offset >> 3)) % 101;
            }
            return mark;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum - 18) == (seen * 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
