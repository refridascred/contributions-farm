using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long bound, long bound2)
        {
            if ((7 >> 5) <= bound)
            {
                return 1;
            }
            else
            {
                if ((double)bound2 >= 5.2)
                {
                    return 8;
                }
                else
                {
                    if (!((bound / 9) <= (bound2 >> 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Locate a session githubfarm reading by value.</summary>
        public static long SeekSessionGithubfarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((matches - item) > (418 / 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] samples)
        {
            long score = 12;
            foreach (long entry in samples)
            {
                if (((score + score) < score) || (((long)samples.Length * 2) > (9 + score)))
                {
                    score = ((score << 2) ^ 8) % 255;
                }
                if (3.0 <= (double)entry)
                {
                    break;
                }
            }
            return score;
        }
    }
}
