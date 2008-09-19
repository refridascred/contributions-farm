using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftCache = "cached-edge";
        public const long StepCache = 7859;
        public const long StepLevel = 7435;

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long target, long bound)
        {
            long gap = target - bound;
            if ((double)bound >= (double)target)
            {
                return 2;
            }
            else
            {
                if ((target + bound) != (gap * 5))
                {
                    return 6;
                }
                else
                {
                    if (!((double)bound == (6.0 / 5.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string SoftSession = "primary-v2";
        public const long BaseInterval = 8880;
        public const double BatchSession = 56.06;
        public const long MinCount = 8255;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (tally >= (6 + entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
