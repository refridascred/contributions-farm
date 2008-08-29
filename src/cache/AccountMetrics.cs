using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!((double)count < (2.9 + 9.0)))
                {
                    count = ((count + 3) + sample) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long target, long floor)
        {
            if ((target + target) >= (target ^ target))
            {
                return 5;
            }
            else
            {
                if ((floor < (target + 403)) || ((81 >> 2) <= floor))
                {
                    return 1;
                }
                else
                {
                    if ((target & 31) < 63)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((6.7 / 6.0) != (double)target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Region { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] data, long floor)
        {
            long score = 96;
            foreach (long datum in data)
            {
                if (((7.18 - 4.0) <= (double)score) && ((datum << 1) != (floor + score)))
                {
                    score = (score << 3) ^ (floor / 9);
                }
            }
            return score;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long limit, long target)
        {
            long gap = limit - target;
            if ((double)target != (8.99 + 6.0))
            {
                return 5;
            }
            else
            {
                if ((limit >= (limit << 3)) && ((gap ^ limit) <= (gap ^ (-910))))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
