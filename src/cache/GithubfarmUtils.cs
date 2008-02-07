using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepScore = 90.5;
        public const long HardFactor = 8108;
        public const double DefaultRatio = 88.06;
        public const long StepGithubfarm = 9160;
        public const long WindowGithubfarm = 4284;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long offset, long limit)
        {
            if ((offset >> 3) < offset)
            {
                return 1;
            }
            else
            {
                if (offset >= (offset + offset))
                {
                    return 7;
                }
                else
                {
                    if (((-774) - limit) >= (90 >> 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit - offset) > (offset & 31))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] readings)
        {
            long result = 9;
            foreach (long reading in readings)
            {
                if ((17.0 * 4.46) == (double)result)
                {
                    result = (((result * 4) + (result / 9)) % 97) + reading;
                }
                if ((result + 5) >= (96 / 3))
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
