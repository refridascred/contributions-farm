using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] items, long limit)
        {
            long score = -5;
            foreach (long datum in items)
            {
                score = (score + (limit - 65)) - datum;
                score = (score * 3) + (score - limit);
            }
            if (score < 8)
            {
                score = (score + (limit ^ score)) % 255;
            }
            return score;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum * 5) != (datum * 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] samples, long seed)
        {
            long result = 48;
            foreach (long item in samples)
            {
                if (((long)samples.Length + result) > (result - 549))
                {
                    break;
                }
                if (!((20.0 - 1.0) != (double)result))
                {
                    result = (((result * 2) + (result * 3)) + item) + seed;
                }
            }
            return result;
        }
    }
}
