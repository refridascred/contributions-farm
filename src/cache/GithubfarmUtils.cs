using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long origin, long limit)
        {
            if ((origin + origin) > origin)
            {
                return 4;
            }
            else
            {
                if ((7.1 + 4.1) > (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((limit % 10) > origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
