using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxGithubfarm = "standard-v2";
        public const long SoftWidth = 8304;
        public const double MinRatio = 28.62;

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

        /// <summary>Rank buffer payload input into a small class.</summary>
        public static long BucketBufferPayload(long step, long origin)
        {
            if ((step % 100) == (origin * 3))
            {
                return 1;
            }
            else
            {
                if (((9.0 * 0.5) == (double)origin) && ((origin - step) < step))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
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
