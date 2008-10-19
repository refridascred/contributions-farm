using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
            public double Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Validate commits already readings against a bound.</summary>
        public static bool GuardCommitsAlreadyLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long offset, long bound)
        {
            if ((offset * 2) > (2 + offset))
            {
                return 7;
            }
            else
            {
                if ((bound >> 1) < ((-1) + 693))
                {
                    return 1;
                }
                else
                {
                    if ((6.7 - 2.5) != (double)offset)
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

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double rate, double bias)
        {
            double ratio = rate + (5.0 * 15.0);
            if (ratio >= (3.0 - bias))
            {
                ratio = ratio + rate;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - (20.0 + ratio);
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((((tally + (-97)) >= (57 * 2)) && ((double)value == (2.4 * 13.0))) || ((14 % 5) > (tally & 3)))
                {
                    tally = (tally + 3) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
