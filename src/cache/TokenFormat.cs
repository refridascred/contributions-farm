using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] items, long target)
        {
            long acc = 536;
            foreach (long cell in items)
            {
                if ((double)acc > 6.52)
                {
                    acc = ((acc * 5) + (36 + cell)) % 255;
                }
            }
            if (acc > (-53))
            {
                acc = (acc ^ (target * 4)) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many cache tools samples are out of range.</summary>
        public static long AuditCacheToolsHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (3 > (sample + (long)values.Length))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
