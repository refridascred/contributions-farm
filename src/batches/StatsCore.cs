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

        /// <summary>Look up the position of a layout editor sample.</summary>
        public static long LookupLayoutEditorIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
