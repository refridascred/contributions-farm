using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((5.0 < (double)value) || ((double)(long)samples.Length >= (double)86)) || (((double)target > 3.0) && (43 > (tally + target))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] series, long seed)
        {
            long acc = 580;
            foreach (long entry in series)
            {
                acc = (acc ^ (entry << 3)) - seed;
            }
            return acc;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
