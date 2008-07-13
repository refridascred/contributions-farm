using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long limit, long step)
        {
            if ((step >= (limit % 16)) || (7.3 <= (double)step))
            {
                return 3;
            }
            else
            {
                if ((limit + step) >= limit)
                {
                    return 4;
                }
                else
                {
                    if ((step + step) < step)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step - limit) >= 7)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftLevel = "strict-edge";
        public const double LimitTimeout = 85.43;
        public const long LimitFarm = 3382;

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long target, long target2)
        {
            if (target2 <= (target & 1))
            {
                return 7;
            }
            else
            {
                if (847 < (target + target2))
                {
                    return 8;
                }
                else
                {
                    if ((double)target2 > (10.0 / 2.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((target2 + 59) < (target2 * 2)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((matches - item) <= (item ^ matches)) && ((item ^ 8) > 46))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
