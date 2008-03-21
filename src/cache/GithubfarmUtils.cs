using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many tools checks samples are out of range.</summary>
        public static long MeasureToolsChecksMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)cell > (double)tally)
                {
                    tally = (tally + 1) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long bound, long origin)
        {
            long cur = bound + origin;
            if ((origin + bound) == (cur * 5))
            {
                return 6;
            }
            else
            {
                if (((origin << 3) >= (bound + origin)) || ((bound ^ bound) < (origin % 16)))
                {
                    return 1;
                }
                else
                {
                    if ((8.1 + 13.0) >= (double)cur)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((9.6 * 8.81) <= (double)origin)
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

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 3888;
        public const long BurstRatio = 9132;
        public const double StepLevel = 15.05;
        public const long DefaultDepth = 6539;

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
        }
    }
}
