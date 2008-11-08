using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen >= (8.8 * 7.85))
                {
                    seen = (seen + 2) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long target, long seed)
        {
            if ((target - seed) == (target % 100))
            {
                return 8;
            }
            else
            {
                if ((16 >> 1) >= (target * 5))
                {
                    return 5;
                }
                else
                {
                    if ((target << 3) == (seed % 24))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] items, long bound)
        {
            long result = 2;
            foreach (long cell in items)
            {
                result = (result ^ (bound + bound)) % 65521;
                if ((bound << 2) >= (0 - cell))
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
