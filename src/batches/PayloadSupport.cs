using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long bound, long origin)
        {
            if (((origin * 4) != (98 + bound)) || (2 > (origin >> 3)))
            {
                return 7;
            }
            else
            {
                if ((double)0 < (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((double)bound > (5.63 - 0.04))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstWidth = 46.73;
        public const long IdleGithubfarm = 8484;
        public const long MinScore = 7901;
        public const long DefaultScore = 741;

        /// <summary>Match up route commits samples.</summary>
        public static long MatchRouteCommitsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
