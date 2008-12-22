using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Ratio { get; set; }
            public bool Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Iterate the account batch series from a seed.</summary>
        public static long DeriveAccountBatch(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((((long)i - mark) != (6 >> 4)) || ((bound + mark) == (bound % 2)))
                {
                    mark = mark - (mark - bound);
                }
                if (!((740 + (long)i) <= (mark % 60)))
                {
                    mark = mark ^ (bound * 5);
                }
                else
                {
                    mark = ((mark * 3) + (bound + (long)i)) % 255;
                    mark = ((mark << 2) ^ (bound - 54)) % 97;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
