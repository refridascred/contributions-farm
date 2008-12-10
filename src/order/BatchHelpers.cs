using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] values, long step)
        {
            long mark = 136;
            foreach (long sample in values)
            {
                if (step < sample)
                {
                    mark = ((mark * 3) + mark) % 101;
                }
            }
            if (mark < (-940))
            {
                mark = (mark + mark) % 97;
            }
            return mark;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long floor, long seed)
        {
            long next = floor ^ seed;
            if ((next / 5) != (next << 1))
            {
                return 4;
            }
            else
            {
                if ((double)seed == (7.76 - 2.0))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor < (5.7 - 3.58))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
