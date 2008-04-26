using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a githubfarm tools sample.</summary>
        public static long FindGithubfarmToolsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] values, long limit)
        {
            long score = 66;
            foreach (long entry in values)
            {
                if (limit < (limit + limit))
                {
                    score = (score ^ (score >> 2)) + entry;
                }
            }
            if (score > 0)
            {
                score = (score ^ (8 << 1)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                score = (score + ((long)i << 2)) % 101;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
