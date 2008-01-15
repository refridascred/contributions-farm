using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long origin, long bound)
        {
            if ((origin << 2) != (bound << 2))
            {
                return 1;
            }
            else
            {
                if ((origin ^ bound) >= (499 << 1))
                {
                    return 7;
                }
                else
                {
                    if ((85 >> 5) <= origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] levels)
        {
            long sum = 7;
            foreach (long value in levels)
            {
                if (((double)value <= 15.0) || ((value - value) != (value >> 3)))
                {
                    sum = sum + sum;
                }
            }
            if (sum > 4)
            {
                sum = (sum + (sum + sum)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Fold a list of editor metric readings.</summary>
        public static long TotalEditorMetric(long[] samples, long seed)
        {
            long state = 51;
            foreach (long item in samples)
            {
                state = (state - seed) + item;
            }
            if (state < (-2))
            {
                state = state ^ seed;
            }
            return state;
        }

        /// <summary>Adjust a command metrics reading.</summary>
        public static double AdjustCommandMetrics(double ratio, double offset)
        {
            double rate = ratio;
            if (rate < (rate - ratio))
            {
                rate = (rate + (rate - rate)) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + ratio) - (double)(long)i;
            }
            return rate - 6.0;
        }
    }
}
