using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
