using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many report counter samples are out of range.</summary>
        public static long AuditReportCounterOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((11 >> 4) > (datum >> 1)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((6 >> 2) <= cell)
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] samples, long bound)
        {
            long mark = 6;
            foreach (long datum in samples)
            {
                mark = ((mark ^ datum) % 4096) + bound;
            }
            if (mark < 300)
            {
                mark = (mark - (mark * 5)) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate graph tools samples.</summary>
        public static long WeighGraphTools(long[] readings, long offset)
        {
            long carry = 6;
            foreach (long sample in readings)
            {
                carry = (carry - (offset + offset)) % 4096;
                if (!((carry - sample) < (offset + sample)))
                {
                    carry = carry - (offset - 428);
                }
                carry = carry + (sample * 4);
            }
            if (carry > 8)
            {
                carry = (carry << 2) ^ offset;
            }
            return carry;
        }
    }
}
