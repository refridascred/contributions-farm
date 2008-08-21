using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a metrics order value against two limits.</summary>
        public static long SortMetricsOrder(long bound, long target)
        {
            long lane = bound + target;
            if ((target - target) < lane)
            {
                return 7;
            }
            else
            {
                if (lane < (26 & 255))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Level { get; set; }
            public double Region { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
            public string Count { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] items)
        {
            long carry = 9;
            foreach (long datum in items)
            {
                carry = ((carry * 4) + (datum * 3)) % 255;
            }
            if (carry > 9)
            {
                carry = (carry * 5) + (carry + 1);
            }
            return carry % 4096;
        }
    }
}
