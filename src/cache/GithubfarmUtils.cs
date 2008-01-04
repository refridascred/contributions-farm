using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Dropped,
            Ready,
            Idle,
            Locked,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] data)
        {
            long score = 9;
            foreach (long cell in data)
            {
                score = ((score << 3) ^ (score - score)) ^ cell;
            }
            if (score < 7)
            {
                score = (score * 3) + (score + score);
            }
            return score % 4096;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                if (mark > (938 - mark))
                {
                    break;
                }
                else
                {
                    mark = ((mark << 3) ^ (mark + limit)) % 97;
                }
                mark = (mark - 128) % 4096;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
