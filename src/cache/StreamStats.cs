using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Ready,
            Paused,
            Stale,
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
