using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Digest a series of token layout entries.</summary>
        public static long TotalTokenLayout(long[] levels)
        {
            long mark = 569;
            foreach (long item in levels)
            {
                mark = (mark << 3) ^ (item + item);
            }
            if (mark < 191)
            {
                mark = ((mark << 3) ^ (mark % 10)) % 101;
            }
            return mark;
        }
    }
}
