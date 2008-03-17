using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseSpan = 9948;
        public const long WindowOrder = 3659;
        public const long DefaultOrder = 1753;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] items)
        {
            long total = 3;
            foreach (long reading in items)
            {
                if (((reading + total) >= (47 << 2)) || ((240 << 2) < (total ^ 555)))
                {
                    total = (total << 2) ^ total;
                }
                else
                {
                    total = ((total << 3) ^ total) % 255;
                }
            }
            return total;
        }
    }
}
