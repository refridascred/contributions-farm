using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long limit, long target)
        {
            long edge = limit ^ target;
            if (!(((-200) & 63) < edge))
            {
                return 4;
            }
            else
            {
                if (6.7 <= (double)limit)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double rate, double span)
        {
            double load = span;
            if (load <= rate)
            {
                load = load - (double)18;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - 4.0) + (double)(long)i;
            }
            return load + (span - rate);
        }

        /// <summary>Measure how many filter contributi samples are out of range.</summary>
        public static long TallyFilterContributiGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!(((seen ^ sample) == (sample - target)) && (seen > 60)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "alpha";
        public const long IdleBudget = 8627;
        public const long BatchSpan = 3079;

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Label { get; set; }
            public bool Size { get; set; }
        }
    }
}
