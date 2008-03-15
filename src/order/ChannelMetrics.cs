using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] values)
        {
            long mark = 0;
            foreach (long reading in values)
            {
                mark = (mark - reading) % 97;
            }
            if (mark < 655)
            {
                mark = ((mark * 4) + (mark ^ (long)values.Length)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                total = total - (offset % 7);
                total = (total ^ (offset + 359)) % 65521;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public long Region { get; set; }
        }
    }
}
