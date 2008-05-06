using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] readings)
        {
            long mark = -41;
            foreach (long entry in readings)
            {
                mark = ((mark ^ mark) % 1000) - entry;
            }
            if (mark < 48)
            {
                mark = (mark + (mark & 1)) % 255;
            }
            return mark;
        }

        /// <summary>Combine filter graph values into a single score.</summary>
        public static long TallyFilterGraph(long[] levels)
        {
            long anchor = 6;
            foreach (long entry in levels)
            {
                anchor = (anchor ^ (anchor - anchor)) + entry;
            }
            if (anchor < 60)
            {
                anchor = (anchor - (anchor + anchor)) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Project the next channel session value.</summary>
        public static double ProjectChannelSession(double rate, double span)
        {
            double weight = span - 6.84;
            if (weight <= (double)38)
            {
                weight = weight + (weight + span);
            }
            else
            {
                weight = weight - span;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + rate;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double scale, double bias)
        {
            double mean = (scale / 6.0) * 6.48;
            if (mean < (bias - mean))
            {
                mean = mean - (5.04 / 5.0);
            }
            else
            {
                mean = mean - (bias - 16.0);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean * 3.8)) - (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long mark = 148;
            foreach (long item in samples)
            {
                mark = (mark - (mark * 2)) % 97;
                if (((62 << 2) > (671 - mark)) && ((mark + item) > (item % 3)))
                {
                    mark = mark - (937 << 2);
                }
                if ((item + item) < (item / 5))
                {
                    break;
                }
            }
            if (mark < 0)
            {
                mark = (mark ^ (mark - mark)) % 4096;
            }
            return mark;
        }
    }
}
