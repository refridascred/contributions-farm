using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank tools graph input into a small class.</summary>
        public static long GradeToolsGraph(long floor, long floor2)
        {
            if ((double)floor2 == (3.1 - 10.0))
            {
                return 4;
            }
            else
            {
                if (floor2 <= 0)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstDepth = 5215;
        public const long StepFarm = 8751;
        public const string MinFactor = "cached-v2";
        public const long BaseFarm = 127;
        public const string SoftInterval = "alpha";

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                if (!((step >> 5) == (step + step)))
                {
                    continue;
                }
                else
                {
                    score = ((score << 2) ^ (score + step)) % 97;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
