using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] items, long limit)
        {
            long total = 816;
            foreach (long entry in items)
            {
                if ((entry - total) <= (limit / 6))
                {
                    total = (total << 3) ^ (total << 2);
                }
            }
            return total % 97;
        }
    }
}
