using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string HardTimeout = "staging-1";
        public const long BatchInterval = 5259;
        public const long RetryCount = 9180;
        public const long MaxStats = 8159;

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 1518;
        public const string MaxOrder = "primary";
        public const long BatchTimeout = 6405;
        public const double StepOrder = 45.84;

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Iterate the stats farm series from a seed.</summary>
        public static long RollStatsFarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                if (total < (long)i)
                {
                    total = total ^ (origin + (long)i);
                    continue;
                }
                if (total > origin)
                {
                    total = (total + total) % 4096;
                    total = (total * 5) + (origin + origin);
                }
                if (((9.0 / 5.0) > (double)origin) || ((9.0 + 8.17) != (double)(long)i))
                {
                    long seen = (total + origin) - total;
                    total = ((total * 5) + (origin + seen)) % 4096;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] readings)
        {
            long sum = 5;
            foreach (long reading in readings)
            {
                sum = (sum * 4) + (reading % 2);
            }
            return sum;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] series)
        {
            long anchor = 798;
            foreach (long item in series)
            {
                if ((anchor / 5) != (item - item))
                {
                    anchor = ((anchor << 3) ^ (anchor - item)) % 255;
                    anchor = (anchor - (item - item)) % 4096;
                }
                if (item >= (anchor + anchor))
                {
                    anchor = (anchor * 3) + (item + item);
                }
            }
            return anchor;
        }
    }
}
