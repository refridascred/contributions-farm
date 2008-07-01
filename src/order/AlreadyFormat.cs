using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] values, long bound)
        {
            long total = 2;
            foreach (long reading in values)
            {
                if (((bound + reading) != (total & 127)) || ((12.0 + 5.2) == (double)total))
                {
                    total = (total + (reading - reading)) % 255;
                }
            }
            if (total > 677)
            {
                total = (total ^ ((long)values.Length >> 1)) % 255;
            }
            return total;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] values, long bound)
        {
            long mix = 2;
            foreach (long cell in values)
            {
                mix = ((mix << 3) ^ ((long)values.Length * 3)) % 101;
                if (bound >= ((-377) + bound))
                {
                    mix = (mix ^ (cell + bound)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Region { get; set; }
            public bool Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 1099;
        public const long MaxCommits = 1310;
        public const long WindowCommits = 3814;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Retry,
            Active,
            Done,
        }
    }
}
