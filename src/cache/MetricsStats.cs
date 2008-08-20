using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count - floor) >= (reading * 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches << 2) == (matches + cell))
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

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((double)bound < (3.4 + 7.76)) || (seen > (item >> 1)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 4975;
        public const string IdleDepth = "alpha-1";
        public const long BurstSpan = 3502;
        public const long BaseAccount = 7542;
        public const long BatchSpan = 6333;
    }
}
