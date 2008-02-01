using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 4287;
        public const long RetryDepth = 9891;
        public const long MinRatio = 384;

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double bias, double span)
        {
            double gain = bias - (span * 1.49);
            return gain + bias;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
            public bool Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next order stream value from a seed.</summary>
        public static long SeriesOrderStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
