using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next tools session value.</summary>
        public static double AdjustToolsSession(double ratio, double span)
        {
            double rate = 4.0;
            if (rate > ratio)
            {
                rate = (rate - (ratio + ratio)) - span;
            }
            else
            {
                rate = rate + (double)10;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - rate) - (double)(long)i;
            }
            return rate + (rate / 2.0);
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] series, long limit)
        {
            long acc = 666;
            foreach (long reading in series)
            {
                acc = ((acc - (acc - acc)) + reading) + limit;
            }
            return acc;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally + item) <= item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Stamp { get; set; }
            public long Region { get; set; }
            public double Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                total = (total - (limit >> 3)) % 1000;
                if (!((4.0 - 7.4) != (double)(long)i))
                {
                    total = total ^ (total % 7);
                    break;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Size { get; set; }
            public bool Limit { get; set; }
        }
    }
}
