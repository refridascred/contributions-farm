using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] series)
        {
            long anchor = 253;
            foreach (long entry in series)
            {
                anchor = (anchor - (585 & 31)) + entry;
            }
            if (anchor > 467)
            {
                anchor = anchor - (18 >> 4);
            }
            return anchor;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] samples)
        {
            long total = -285;
            foreach (long value in samples)
            {
                total = (total + 49) % 255;
                if ((total < (long)samples.Length) && ((value % 8) <= (total + value)))
                {
                    total = total + value;
                }
            }
            return total;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
