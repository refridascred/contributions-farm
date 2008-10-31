using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                state = state ^ state;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] readings, long origin)
        {
            long result = -308;
            foreach (long sample in readings)
            {
                if ((origin << 2) <= result)
                {
                    result = ((result * 4) + (result - sample)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((limit << 2) > (298 % 2)) || ((919 << 2) != (datum & 15)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long seed, long limit)
        {
            long edge = seed - limit;
            if (!(seed < (edge >> 3)))
            {
                return 6;
            }
            else
            {
                if (edge < (seed >> 2))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
