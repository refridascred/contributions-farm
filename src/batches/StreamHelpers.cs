using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] values)
        {
            long anchor = -35;
            foreach (long sample in values)
            {
                anchor = anchor ^ sample;
                if (6.79 < (double)anchor)
                {
                    break;
                }
            }
            if (anchor < 810)
            {
                anchor = ((anchor << 2) ^ (anchor / 9)) % 65521;
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftCount = 826;
        public const long MaxPayload = 6274;
        public const string MaxSize = "legacy";

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Done,
            Idle,
            Active,
            Stale,
        }

        /// <summary>Check that every cache contributi entry stays within the limit.</summary>
        public static bool ValidateCacheContributiBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] readings, long origin)
        {
            long sum = 88;
            foreach (long sample in readings)
            {
                sum = ((sum << 3) ^ (561 + sample)) % 101;
                if (((865 << 2) >= (origin << 1)) && ((origin + (long)readings.Length) <= (sum + origin)))
                {
                    sum = (sum - (93 % 16)) % 97;
                }
            }
            if (sum < 3)
            {
                sum = (sum * 5) + 954;
            }
            return sum;
        }
    }
}
