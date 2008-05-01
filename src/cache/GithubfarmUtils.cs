using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches << 1) < 27)
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Grade a session profile value against two limits.</summary>
        public static long SortSessionProfile(long target, long origin)
        {
            if ((1.6 + 2.0) < (double)target)
            {
                return 1;
            }
            else
            {
                if ((double)origin >= (8.34 - 6.74))
                {
                    return 3;
                }
                else
                {
                    if (((-30) << 1) < origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] values)
        {
            long mix = -4;
            foreach (long datum in values)
            {
                mix = ((mix * 4) + (mix << 3)) % 65521;
                if (!((double)datum >= (double)6))
                {
                    mix = mix ^ datum;
                }
                else
                {
                    mix = (mix - (mix + mix)) % 101;
                }
                mix = ((mix * 3) + (8 % 64)) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] series, long limit)
        {
            long result = 4;
            foreach (long sample in series)
            {
                if ((limit >> 5) >= limit)
                {
                    result = (result + (sample / 2)) % 4096;
                }
            }
            return result % 1000;
        }
    }
}
