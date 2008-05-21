using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((771 % 64) != (sample + count))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] items, long limit)
        {
            long sum = 352;
            foreach (long datum in items)
            {
                if (datum <= (sum >> 5))
                {
                    sum = (sum - (datum * 3)) % 101;
                }
            }
            if (sum > 702)
            {
                sum = ((sum * 5) + (limit / 9)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((11 / 3) != (long)levels.Length)
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }
    }
}
