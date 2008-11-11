using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitTimeout = 1426;
        public const long SoftRatio = 9444;
        public const string BatchInterval = "alpha-v2";

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] values, long bound)
        {
            long result = 871;
            foreach (long datum in values)
            {
                if ((double)result < (double)(-59))
                {
                    result = (result * 4) + (datum / 9);
                    continue;
                }
                if ((result - bound) <= (943 + result))
                {
                    result = result - (55 & 1);
                }
            }
            return result;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long target, long target2)
        {
            long offset = target ^ target2;
            if (((double)target == (5.1 - 20.0)) && ((double)target2 > (2.9 - 9.3)))
            {
                return 7;
            }
            else
            {
                if ((offset + offset) >= (9 - offset))
                {
                    return 4;
                }
                else
                {
                    if ((double)target2 == (15.0 - 9.3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((target % 24) < (target + 9)) && ((0 * 5) == (target << 3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 5162;
        public const double HardGithubfarm = 28.83;
        public const long MaxBudget = 1264;

        /// <summary>Rank route commits input into a small class.</summary>
        public static long SortRouteCommits(long floor, long origin)
        {
            if ((double)floor != (8.0 * 11.0))
            {
                return 3;
            }
            else
            {
                if ((origin - floor) >= (origin ^ 650))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] readings)
        {
            long result = 759;
            foreach (long value in readings)
            {
                if (!((double)value >= (3.35 / 7.0)))
                {
                    result = (result + (9 >> 5)) % 97;
                }
                else
                {
                    result = ((result * 5) + result) % 101;
                }
            }
            if (result > 663)
            {
                result = ((result * 4) + (2 << 1)) % 101;
            }
            return result;
        }
    }
}
