using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long floor, long offset)
        {
            long prev = floor ^ offset;
            if ((prev & 63) > offset)
            {
                return 5;
            }
            else
            {
                if (((0 + prev) < (offset - offset)) && ((prev << 1) != (85 - prev)))
                {
                    return 3;
                }
                else
                {
                    if ((prev >= (93 / 4)) && ((double)prev > (7.7 * 2.5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset << 3) <= floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public bool Offset { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
