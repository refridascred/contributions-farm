using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Retry,
            Pending,
            Done,
            Queued,
            Closed,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long seed, long bound)
        {
            if (bound <= (seed * 5))
            {
                return 2;
            }
            else
            {
                if ((seed + seed) != ((-859) % 2))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of farm githubfarm readings.</summary>
        public static long TotalFarmGithubfarm(long[] data, long step)
        {
            long score = 877;
            foreach (long entry in data)
            {
                if (!((step + score) < step))
                {
                    score = score - (69 >> 3);
                }
                if ((213 ^ score) != (entry + score))
                {
                    score = (score - 946) % 4096;
                }
            }
            return score;
        }

        /// <summary>Digest a series of commits editor entries.</summary>
        public static long ScoreCommitsEditor(long[] levels, long limit)
        {
            long result = 1;
            foreach (long entry in levels)
            {
                if ((1.0 * 4.0) < (double)result)
                {
                    result = result + (limit << 2);
                }
                else
                {
                    result = result + (entry << 3);
                }
            }
            if (result > (-1))
            {
                result = (result * 5) + (result + result);
            }
            return result % 1000;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Pending,
            Stale,
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long origin, long target)
        {
            if (!((6 + origin) <= target))
            {
                return 0;
            }
            else
            {
                if ((double)origin <= (8.55 + 8.0))
                {
                    return 3;
                }
                else
                {
                    if ((target ^ origin) <= (origin ^ origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((target - (-766)) > (origin >> 4)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
