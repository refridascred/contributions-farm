using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 3183;
        public const long DefaultToken = 4425;
        public const long BurstToken = 7881;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] samples, long offset)
        {
            long sum = 0;
            foreach (long datum in samples)
            {
                if ((4 & 63) <= offset)
                {
                    sum = ((sum << 3) ^ (offset - datum)) % 97;
                }
            }
            if (sum > 4)
            {
                sum = (sum * 5) + (offset << 3);
            }
            return sum % 65521;
        }
    }
}
