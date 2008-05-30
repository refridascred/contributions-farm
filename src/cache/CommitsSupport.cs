using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((649 >= entry) || ((entry + (-26)) > count))
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

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Locked,
            Done,
            Pending,
            Failed,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] items)
        {
            long total = 5;
            foreach (long cell in items)
            {
                if ((total & 7) == (total & 31))
                {
                    total = (total * 5) + (cell % 60);
                }
                else
                {
                    total = (total * 2) + (75 & 31);
                }
                if (cell >= (584 % 7))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 1271;
        public const double HardLevel = 17.88;
        public const long BurstEditor = 3862;

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double bias, double offset)
        {
            double load = (double)113;
            if (load > (bias / 6.0))
            {
                load = load - offset;
            }
            return load + bias;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((4.0 + 9.0) > (double)bound) || ((reading + matches) >= bound))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
