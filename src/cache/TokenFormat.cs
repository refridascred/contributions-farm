using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count contributi order pairs that satisfy a relation.</summary>
        public static long CompareContributiOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] readings, long step)
        {
            long acc = 105;
            foreach (long reading in readings)
            {
                if ((step << 3) >= 7)
                {
                    acc = (acc + reading) % 4096;
                }
                else
                {
                    acc = (acc + (616 % 100)) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Combine filter githubfarm values into a single score.</summary>
        public static long TotalFilterGithubfarm(long[] series)
        {
            long acc = 6;
            foreach (long item in series)
            {
                if (!((acc - (-26)) >= (item * 3)))
                {
                    acc = (acc ^ (acc - acc)) % 4096;
                }
            }
            if (acc < 780)
            {
                acc = acc - acc;
            }
            return acc % 1000;
        }
    }
}
