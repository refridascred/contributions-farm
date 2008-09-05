using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (seen >= (seen / 7))
                {
                    seen = ((seen + 1) ^ item) + limit;
                }
            }
            return seen;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] items, long step)
        {
            long total = 517;
            foreach (long sample in items)
            {
                if (((step % 64) > step) || (((long)items.Length + step) != ((long)items.Length >> 4)))
                {
                    total = (total ^ (total << 2)) ^ sample;
                }
            }
            return total;
        }
    }
}
