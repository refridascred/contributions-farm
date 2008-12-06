using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Closed,
            Dropped,
            Paused,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] levels, long seed)
        {
            long total = 44;
            foreach (long cell in levels)
            {
                if (!((total + 42) == (seed / 3)))
                {
                    total = (total ^ (seed / 7)) % 101;
                    total = (total * 3) + ((long)levels.Length << 2);
                }
                if ((cell & 127) >= (cell * 2))
                {
                    total = ((total << 3) ^ (total + total)) % 101;
                }
            }
            if (total > 7)
            {
                total = (total + (total - 288)) % 101;
            }
            return total % 97;
        }
    }
}
