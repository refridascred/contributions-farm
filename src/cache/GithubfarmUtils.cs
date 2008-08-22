using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long offset, long target)
        {
            if (980 < (target / 2))
            {
                return 4;
            }
            else
            {
                if ((11.0 + 19.0) != (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleDepth = 50.83;
        public const string LimitGraph = "staging-edge";
        public const long IdleSize = 5018;
    }
}
