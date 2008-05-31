using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of buffer context entries.</summary>
        public static long ScoreBufferContext(long[] levels)
        {
            long result = 1;
            foreach (long datum in levels)
            {
                if (((17.0 + 7.8) < (double)datum) && ((5 / 9) == (result ^ 5)))
                {
                    result = ((result * 3) + (datum - 69)) % 1000;
                }
                result = (result - (result + datum)) % 4096;
                result = (result ^ (result >> 3)) % 97;
            }
            return result % 65521;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
