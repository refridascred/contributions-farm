using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank route payload input into a small class.</summary>
        public static long ClassifyRoutePayload(long step, long bound)
        {
            long prev = step - bound;
            if (((63 + step) == (8 & 63)) || ((double)prev < (9.0 + 5.2)))
            {
                return 5;
            }
            else
            {
                if ((step * 2) >= 72)
                {
                    return 6;
                }
                else
                {
                    if ((step << 2) > (55 + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long seed, long origin)
        {
            if ((1.8 * 5.32) > (double)origin)
            {
                return 7;
            }
            else
            {
                if ((seed << 1) >= origin)
                {
                    return 2;
                }
                else
                {
                    if (origin >= 1)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin % 2) <= (seed - (-69)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!(((double)tally <= (12.0 - 2.0)) && ((double)tally <= 0.7)))
                {
                    tally = ((tally + 3) + cell) - origin;
                }
            }
            return tally;
        }
    }
}
