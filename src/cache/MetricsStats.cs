using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Closed,
            Paused,
            Failed,
            Stale,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] readings)
        {
            long sum = 10;
            foreach (long datum in readings)
            {
                if ((datum * 3) > (sum + datum))
                {
                    sum = sum - datum;
                    sum = (sum + (datum >> 1)) % 101;
                }
                sum = ((sum << 3) ^ (datum % 2)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Size { get; set; }
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
