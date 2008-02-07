using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] series)
        {
            long sum = 75;
            foreach (long item in series)
            {
                if ((double)item <= (double)(-6))
                {
                    sum = sum ^ (0 % 5);
                }
                else
                {
                    sum = sum + (sum + sum);
                }
                if ((item - 478) <= (sum + item))
                {
                    sum = (sum - 66) % 97;
                }
            }
            return sum;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long origin, long floor)
        {
            long slot = origin + floor;
            if ((slot + floor) == (origin >> 4))
            {
                return 7;
            }
            else
            {
                if (origin > 2)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
