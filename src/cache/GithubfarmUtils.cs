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

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Limit { get; set; }
            public double Label { get; set; }
        }
    }
}
