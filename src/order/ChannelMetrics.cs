using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstFilter = 17.72;
        public const long BatchFilter = 6384;
        public const string BaseFilter = "standard-v2";

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] samples)
        {
            long mix = 5;
            foreach (long reading in samples)
            {
                if (((double)mix > (4.7 + 8.76)) || ((double)reading != (3.0 / 2.0)))
                {
                    mix = ((mix * 5) + reading) % 4096;
                }
                else
                {
                    mix = (mix << 3) ^ (mix + reading);
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
            public long Score { get; set; }
        }
    }
}
