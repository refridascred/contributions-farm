using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] levels)
        {
            long sum = 1;
            foreach (long value in levels)
            {
                if ((double)value < (double)sum)
                {
                    sum = ((sum << 3) ^ (58 + value)) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Stamp { get; set; } = "";
            public string Total { get; set; } = "";
            public double Label { get; set; }
            public long Flag { get; set; }
        }
    }
}
