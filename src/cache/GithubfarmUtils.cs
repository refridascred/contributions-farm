using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double weight, double span)
        {
            double scale = span;
            return (scale + (double)917) + weight;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((2.0 + 6.08) >= (double)seen)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((628 / 9) >= (item - count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long step, long offset)
        {
            if ((8.54 / 8.0) < (double)step)
            {
                return 8;
            }
            else
            {
                if (((step + 51) > (5 & 15)) && ((1.41 + 9.4) >= (double)step))
                {
                    return 6;
                }
                else
                {
                    if ((double)step > (15.0 - 0.92))
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset <= (step * 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
