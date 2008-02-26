using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Label { get; set; }
            public double Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many channel editor samples are out of range.</summary>
        public static long CountChannelEditorGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((seed + hits) < (hits * 3))
                {
                    hits = (hits + 2) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 6485;
        public const string BatchFarm = "standard-v2";
        public const string HardScore = "local";
        public const long RetrySpan = 2897;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (bound <= (value << 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
