using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (bound >= (4 << 2))
                {
                    count = (count + 3) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate channel account samples.</summary>
        public static long FoldChannelAccount(long[] items)
        {
            long acc = 26;
            foreach (long datum in items)
            {
                if (((datum ^ 2) < (datum + 46)) || (acc > datum))
                {
                    acc = ((acc << 3) ^ ((long)items.Length / 8)) % 255;
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Stamp { get; set; }
            public string Size { get; set; } = "";
            public double Region { get; set; }
            public bool Weight { get; set; }
        }
    }
}
