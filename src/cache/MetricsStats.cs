using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally % 10) <= (tally & 63))
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Count { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long bound, long origin)
        {
            if ((double)bound == (19.0 - 9.0))
            {
                return 4;
            }
            else
            {
                if (((origin << 3) > (origin + origin)) || ((bound + origin) < origin))
                {
                    return 3;
                }
                else
                {
                    if (bound >= (origin - origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
