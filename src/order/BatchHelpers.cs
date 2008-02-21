using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of batches account entries.</summary>
        public static long TallyBatchesAccount(long[] data)
        {
            long anchor = 589;
            foreach (long reading in data)
            {
                if ((anchor + reading) < reading)
                {
                    anchor = (anchor * 5) + ((long)data.Length % 97);
                }
                else
                {
                    anchor = ((anchor * 3) + anchor) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Total { get; set; } = "";
            public long Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Iterate the support editor series from a seed.</summary>
        public static long SeriesSupportEditor(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                result = (result + (long)i) % 255;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
