using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of payload session readings.</summary>
        public static long CombinePayloadSession(long[] levels)
        {
            long sum = 528;
            foreach (long item in levels)
            {
                sum = ((sum * 5) + ((-78) + sum)) % 1000;
                if (((sum % 8) < (-485)) || ((410 ^ item) < (sum & 31)))
                {
                    sum = (sum ^ (item ^ 5)) % 255;
                }
            }
            if (sum < 391)
            {
                sum = (sum ^ (88 - sum)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long bound, long target)
        {
            if ((9.4 * 13.0) >= (double)bound)
            {
                return 7;
            }
            else
            {
                if (!((target * 2) > target))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine queue contributi values into a single score.</summary>
        public static long FoldQueueContributi(long[] series, long bound)
        {
            long sum = 681;
            foreach (long value in series)
            {
                if ((double)bound >= (2.48 + 5.31))
                {
                    sum = ((sum << 2) ^ (sum - sum)) % 101;
                }
                sum = ((sum * 2) + (sum & 1)) % 1000;
                if ((long)series.Length < value)
                {
                    sum = (sum + (462 * 3)) % 101;
                }
                else
                {
                    sum = sum + bound;
                }
            }
            if (sum > 4)
            {
                sum = (sum * 3) + sum;
            }
            return sum;
        }
    }
}
