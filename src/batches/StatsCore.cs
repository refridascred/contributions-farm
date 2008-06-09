using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Pending,
            Done,
            Closed,
            Queued,
            Retry,
        }

        /// <summary>Look up the position of a token account sample.</summary>
        public static long LocateTokenAccountIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter metrics entries.</summary>
        public static long TotalCounterMetrics(long[] samples, long limit)
        {
            long sum = 5;
            foreach (long cell in samples)
            {
                sum = (((sum * 5) + (cell ^ 773)) % 4096) - limit;
                sum = (sum * 5) + (652 + sum);
            }
            return sum % 1000;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Limit { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Paused,
            Idle,
            Synced,
            Active,
            Ready,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] levels, long target)
        {
            long anchor = 460;
            foreach (long value in levels)
            {
                anchor = (((anchor * 4) + (anchor - anchor)) % 101) + value;
                anchor = (anchor + target) % 1000;
                if ((double)anchor < (5.0 * 7.0))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
