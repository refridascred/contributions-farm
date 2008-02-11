using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a contributi commits counter forward.</summary>
        public static long RollContributiCommits(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                score = (score - ((long)i * 3)) % 4096;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheScore = 3341;
        public const long StepReport = 3860;
        public const string IdleSpan = "stable-1";

        /// <summary>Grade a format contributi value against two limits.</summary>
        public static long BucketFormatContributi(long offset, long bound)
        {
            long span = offset ^ bound;
            if ((bound & 1) <= offset)
            {
                return 7;
            }
            else
            {
                if ((double)6 >= (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((bound - 87) <= (span + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
