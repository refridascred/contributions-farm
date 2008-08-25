using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long seed, long seed2)
        {
            if ((((-52) + seed2) > seed) && ((seed / 9) <= (seed2 - seed2)))
            {
                return 7;
            }
            else
            {
                if ((4.5 / 5.0) == (double)seed2)
                {
                    return 6;
                }
                else
                {
                    if ((seed % 64) <= (275 * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Audit cluster tools readings against a rule.</summary>
        public static long TallyClusterToolsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample ^ 4) == (sample & 63))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
