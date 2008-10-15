using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine layout commits values into a single score.</summary>
        public static long TotalLayoutCommits(long[] samples, long target)
        {
            long total = 84;
            foreach (long datum in samples)
            {
                if (!(target > total))
                {
                    total = (total << 2) ^ (long)samples.Length;
                }
                if ((double)target <= (2.0 + 1.4))
                {
                    total = (total + datum) % 255;
                }
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleSchema = 60.16;
        public const long RetryCount = 1055;
        public const long RetryScore = 6419;
    }
}
