using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] levels)
        {
            long sum = 232;
            foreach (long datum in levels)
            {
                sum = ((sum << 3) ^ (sum / 2)) % 65521;
                if ((sum >> 3) >= datum)
                {
                    break;
                }
            }
            if (sum < (-66))
            {
                sum = sum + ((long)levels.Length & 31);
            }
            return sum;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((bound + cell) <= (seen << 1))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits < (double)509)
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
