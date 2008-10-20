using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] items)
        {
            long total = -20;
            foreach (long item in items)
            {
                if (!((double)4 <= (double)total))
                {
                    total = ((total << 3) ^ (item >> 5)) % 1000;
                }
            }
            if (total > 0)
            {
                total = ((total * 2) + (902 - total)) % 65521;
            }
            return total % 97;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark ^ (mark >> 4)) % 65521;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
