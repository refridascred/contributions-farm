using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((9.0 * 13.0) >= (double)limit) || ((double)limit != (double)reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (total - limit)) % 97;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = (((total * 5) + 7) % 4096) ^ (long)i2;
                    total = total - (limit - limit);
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of payload counter entries.</summary>
        public static long CombinePayloadCounter(long[] values, long floor)
        {
            long anchor = 824;
            foreach (long sample in values)
            {
                if (4 <= sample)
                {
                    continue;
                }
                if ((anchor - sample) <= sample)
                {
                    anchor = (((anchor * 4) + (sample * 2)) % 65521) - floor;
                }
            }
            return anchor;
        }
    }
}
