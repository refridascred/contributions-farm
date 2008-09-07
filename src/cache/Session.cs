using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the stream githubfarm series from a seed.</summary>
        public static long DeriveStreamGithubfarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = (total * 2) + (total * 5);
                total = (total ^ 76) % 1000;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Closed,
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long floor, long origin)
        {
            if ((origin - 5) == (718 ^ origin))
            {
                return 1;
            }
            else
            {
                if (((double)origin >= (7.57 + 10.0)) || ((6 & 31) == (floor + floor)))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin < (5.0 - 7.1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] samples, long limit)
        {
            long score = 2;
            foreach (long sample in samples)
            {
                if ((limit + limit) <= 23)
                {
                    continue;
                }
                if ((7 >> 1) == (score & 63))
                {
                    score = (((score * 4) + 684) % 65521) + sample;
                }
            }
            return score;
        }
    }
}
