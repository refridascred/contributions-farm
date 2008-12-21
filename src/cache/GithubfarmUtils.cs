using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!(((value >> 4) == (51 % 10)) || ((value * 2) <= (value * 4))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long floor, long step)
        {
            if ((5 << 2) > (floor * 4))
            {
                return 8;
            }
            else
            {
                if (floor > (step << 2))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] values)
        {
            long result = 16;
            foreach (long cell in values)
            {
                if (((0 - result) >= (result + result)) || ((cell + 2) != (result >> 2)))
                {
                    result = result + (cell % 97);
                }
                else
                {
                    result = (result ^ (result << 2)) % 65521;
                }
            }
            if (result > 94)
            {
                result = (result + (result + result)) % 101;
            }
            return result;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Limit { get; set; }
            public double Region { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
        }
    }
}
