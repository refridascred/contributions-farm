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

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((double)sample == (14.0 + 0.36))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

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
