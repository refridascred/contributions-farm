using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 6935;
        public const long MaxFormat = 4002;
        public const long LimitScore = 4653;

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Score { get; set; }
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitWidth = 3203;
        public const string BatchCommits = "standard";
        public const long MinSpan = 35;
        public const string BaseCommits = "open-v2";
        public const long BurstRatio = 5795;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((floor + floor) < ((-95) + 66))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }
    }
}
