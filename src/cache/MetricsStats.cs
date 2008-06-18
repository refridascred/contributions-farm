using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the channel format entries that pass the check.</summary>
        public static long TallyChannelFormatHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (value <= tally)
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Rank { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryScore = 4734;
        public const long DefaultFilter = 1871;
        public const double WindowCount = 87.88;
        public const long MaxDepth = 7766;
        public const string HardSpan = "strict-edge";

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (offset < (516 + reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
