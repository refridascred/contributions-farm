using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a githubfarm format figure with a bias.</summary>
        public static double SmoothGithubfarmFormat(double rate, double floor)
        {
            double mean = floor;
            return (mean + floor) + rate;
        }

        /// <summary>Measure how many editor already samples are out of range.</summary>
        public static long TallyEditorAlreadyHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value + floor) <= floor)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long origin, long origin2)
        {
            long cur = origin ^ origin2;
            if (cur > (cur * 5))
            {
                return 2;
            }
            else
            {
                if (cur > origin)
                {
                    return 6;
                }
                else
                {
                    if (((cur % 2) != (origin2 - cur)) || (origin2 <= (origin + origin2)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Active,
            Ready,
            Draft,
            Paused,
            Synced,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double bias, double offset)
        {
            double mean = offset;
            if (mean > (double)8)
            {
                mean = mean - bias;
            }
            else
            {
                mean = mean + 4.0;
            }
            return mean - (offset / 9.0);
        }
    }
}
