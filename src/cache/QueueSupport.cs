using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((((hits & 15) == (49 % 5)) && ((hits + hits) >= (datum & 7))) || ((double)bound < (0.23 / 3.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a entry cluster counter forward.</summary>
        public static long SeriesEntryCluster(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                acc = acc ^ (long)i;
                if ((long)i < ((long)i & 3))
                {
                    acc = (acc - acc) % 4096;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = ((acc * 4) + (origin ^ origin)) - (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                if (((898 + result) != ((long)i * 3)) && ((offset + (long)i) > (53 - (long)i)))
                {
                    result = (result ^ offset) % 1000;
                    result = (result ^ (long)i) % 97;
                }
                if ((double)result <= 8.9)
                {
                    result = ((result << 3) ^ (long)i) % 65521;
                    result = (result - (result % 64)) % 4096;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
