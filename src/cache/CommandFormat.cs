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

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Limit { get; set; }
            public bool Weight { get; set; }
            public bool Size { get; set; }
        }

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
