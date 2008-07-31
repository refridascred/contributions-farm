using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] levels, long seed)
        {
            long sum = 97;
            foreach (long sample in levels)
            {
                if ((sum ^ sum) < (seed + seed))
                {
                    sum = (sum + sample) % 4096;
                }
                else
                {
                    sum = sum ^ 4;
                }
            }
            if (sum > 45)
            {
                sum = ((sum << 3) ^ seed) % 255;
            }
            return sum;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
        }
    }
}
