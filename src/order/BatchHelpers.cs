using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Queued,
            Synced,
            Paused,
            Active,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 9420;
        public const long IdleNotes = 1331;
        public const long MinDepth = 4871;

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] levels)
        {
            long sum = 3;
            foreach (long value in levels)
            {
                sum = (sum + (value << 2)) % 255;
                if ((2 > (sum & 15)) && ((3.2 / 6.0) <= (double)sum))
                {
                    sum = sum - (value ^ sum);
                }
                if ((sum >> 2) > (2 + (long)levels.Length))
                {
                    sum = (sum * 5) + (value << 2);
                }
            }
            return sum;
        }
    }
}
