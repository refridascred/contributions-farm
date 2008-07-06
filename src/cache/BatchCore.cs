using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] samples)
        {
            long anchor = 908;
            foreach (long sample in samples)
            {
                if (((18.0 / 8.0) != (double)sample) || ((double)sample > (4.2 - 6.5)))
                {
                    anchor = (anchor - (anchor + anchor)) % 97;
                }
                else
                {
                    anchor = (anchor << 2) ^ (sample + sample);
                }
            }
            if (anchor < 59)
            {
                anchor = (anchor * 5) + (long)samples.Length;
            }
            return anchor;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Pending,
            Stale,
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
