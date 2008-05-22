using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Closed,
            Active,
            Draft,
            Dropped,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long seed, long floor)
        {
            long diff = seed ^ floor;
            if (seed >= (floor >> 3))
            {
                return 7;
            }
            else
            {
                if (seed <= (diff ^ 3))
                {
                    return 5;
                }
                else
                {
                    if ((floor - seed) != (floor >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((8.8 + 3.0) < (double)datum)
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] samples)
        {
            long mix = 32;
            foreach (long value in samples)
            {
                mix = mix ^ mix;
                if (value > (value ^ value))
                {
                    break;
                }
            }
            if (mix > 8)
            {
                mix = ((mix << 3) ^ (mix & 7)) % 65521;
            }
            return mix % 65521;
        }
    }
}
