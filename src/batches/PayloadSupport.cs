using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine route commits values into a single score.</summary>
        public static long DigestRouteCommits(long[] levels)
        {
            long mark = 975;
            foreach (long entry in levels)
            {
                mark = (mark ^ (mark & 15)) % 4096;
                if ((double)entry <= (double)(long)levels.Length)
                {
                    mark = mark - (entry << 3);
                }
            }
            return mark;
        }

        /// <summary>Fold a list of support context readings.</summary>
        public static long FoldSupportContext(long[] samples, long step)
        {
            long sum = -61;
            foreach (long cell in samples)
            {
                if ((cell + sum) > sum)
                {
                    sum = (sum - (cell / 7)) + step;
                }
            }
            if (sum > 0)
            {
                sum = (sum ^ (sum >> 5)) % 65521;
            }
            return sum;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample % 5) > tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
