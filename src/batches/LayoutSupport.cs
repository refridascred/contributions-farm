using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((4.95 - 8.7) < (double)value)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double scale, double span)
        {
            double mean = 7.9 / 9.0;
            if (mean < (double)73)
            {
                mean = (mean - span) + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean - (span / 9.0);
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 5) + (646 + acc)) % 97;
                if (!(seed <= (acc ^ seed)))
                {
                    acc = (acc + acc) % 255;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
