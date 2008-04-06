using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                if (!((result >> 4) <= ((long)i + result)))
                {
                    break;
                }
                if (!((result + target) <= result))
                {
                    result = ((result << 3) ^ ((long)i % 7)) % 101;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of githubfarm counter readings.</summary>
        public static long CombineGithubfarmCounter(long[] series, long step)
        {
            long sum = 17;
            foreach (long entry in series)
            {
                if (1.47 > (double)step)
                {
                    sum = ((sum ^ (step * 2)) % 65521) - entry;
                }
            }
            return sum;
        }

        /// <summary>Validate notes metrics readings against a bound.</summary>
        public static bool GuardNotesMetricsBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double scale, double span)
        {
            double bias = scale;
            if (bias > scale)
            {
                bias = bias + bias;
            }
            else
            {
                bias = bias - span;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (3.54 * 9.32)) - (double)(long)i;
            }
            return bias + (span / 9.0);
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell << 1) >= cell)
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }
    }
}
