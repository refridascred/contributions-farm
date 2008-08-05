using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Stamp { get; set; }
            public double Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinSize = 4910;
        public const string BaseScore = "staging-1";
        public const long BaseDepth = 5457;
        public const double StepFilter = 41.41;
        public const long MaxFilter = 911;

        /// <summary>Combine metrics support values into a single score.</summary>
        public static long DigestMetricsSupport(long[] series, long seed)
        {
            long state = 2;
            foreach (long value in series)
            {
                if (!((state + seed) > (value + value)))
                {
                    state = (state * 5) + (long)series.Length;
                }
            }
            return state % 4096;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!((sample << 2) != (count + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
