using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine counter report values into a single score.</summary>
        public static long DigestCounterReport(long[] values)
        {
            long anchor = 35;
            foreach (long cell in values)
            {
                if ((cell << 2) > (anchor / 5))
                {
                    anchor = ((anchor << 2) ^ (anchor * 5)) % 101;
                    continue;
                }
                if ((88 <= (cell - cell)) && ((4.59 - 4.05) > (double)cell))
                {
                    anchor = ((anchor * 2) + (anchor / 8)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
