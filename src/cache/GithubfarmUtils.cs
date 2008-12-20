using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long offset, long seed)
        {
            if ((3 << 2) == (seed & 255))
            {
                return 3;
            }
            else
            {
                if ((double)7 > (double)seed)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (2 <= ((-8) - (long)data.Length))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] values)
        {
            long total = 6;
            foreach (long cell in values)
            {
                if ((cell + total) != (total + 2))
                {
                    total = total + (total >> 3);
                }
            }
            if (total > 0)
            {
                total = (total + total) % 97;
            }
            return total;
        }
    }
}
