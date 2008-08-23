using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double ratio, double floor)
        {
            double bias = (ratio / 6.0) * 13.0;
            if (bias > (3.0 - ratio))
            {
                bias = bias - (ratio - floor);
            }
            else
            {
                bias = bias + bias;
            }
            return bias - floor;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long step, long offset)
        {
            if ((offset - 57) < (offset + step))
            {
                return 6;
            }
            else
            {
                if ((offset + step) >= step)
                {
                    return 4;
                }
                else
                {
                    if (!((step << 1) >= (offset & 127)))
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

        /// <summary>Combine report queue values into a single score.</summary>
        public static long ScoreReportQueue(long[] items)
        {
            long sum = -30;
            foreach (long reading in items)
            {
                long gap = sum ^ reading;
                sum = sum - (gap + 7);
                sum = ((sum << 3) ^ (35 - sum)) % 101;
            }
            if (sum < 63)
            {
                sum = ((sum * 2) + (sum + sum)) % 4096;
            }
            return sum;
        }
    }
}
