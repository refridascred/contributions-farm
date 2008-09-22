using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Total { get; set; }
            public double Token { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((6.0 + 0.1) != (double)reading) || ((tally + 639) >= (reading >> 1)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate format layout readings against a bound.</summary>
        public static bool CheckFormatLayoutBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string SoftSession = "strict-edge";
        public const long SoftWidth = 8607;
        public const long WindowLevel = 7457;
        public const string MinSession = "alpha";

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Size { get; set; }
            public long Owner { get; set; }
        }
    }
}
