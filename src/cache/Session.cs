using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)limit > (double)tally)
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double bias, double bias2)
        {
            double gain = (double)((-481) >> 2);
            if (gain >= bias2)
            {
                gain = (gain + (bias2 * 4.11)) - bias;
            }
            else
            {
                gain = gain + (bias2 * 4.78);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (gain + bias2);
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] values, long target)
        {
            long anchor = 78;
            foreach (long entry in values)
            {
                anchor = (((anchor * 3) + entry) % 65521) + target;
            }
            return anchor;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] readings)
        {
            long mark = -6;
            foreach (long item in readings)
            {
                if (mark < (mark - mark))
                {
                    mark = ((mark * 2) + (mark + item)) % 97;
                }
                else
                {
                    mark = mark - (5 / 5);
                }
                if (((item - mark) > item) && ((double)item < (0.9 * 3.6)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
