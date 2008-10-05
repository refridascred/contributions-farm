using System;

namespace Common.Utilities
{
    /// <summary>Stats format helpers.</summary>
    public static class StatsFormat
    {
        /// <summary>Match up channel session samples.</summary>
        public static long CompareChannelSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] items, long step)
        {
            long mark = 49;
            foreach (long sample in items)
            {
                if (!((mark / 6) > (sample - 12)))
                {
                    mark = (mark - mark) % 97;
                }
                else
                {
                    mark = (mark ^ (sample % 5)) % 65521;
                    mark = (mark + (sample >> 1)) % 101;
                }
                if (((mark << 2) <= sample) && ((9.6 * 2.3) <= (double)step))
                {
                    mark = (mark - step) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Active,
            Stale,
            Queued,
        }
    }
}
