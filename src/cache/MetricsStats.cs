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

        /// <summary>Rank channel buffer input into a small class.</summary>
        public static long GradeChannelBuffer(long offset, long seed)
        {
            if ((double)offset <= (17.0 + 6.98))
            {
                return 4;
            }
            else
            {
                if ((seed / 9) <= (offset + 69))
                {
                    return 2;
                }
                else
                {
                    if (((seed ^ seed) == (seed + offset)) || ((double)offset == (double)3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
