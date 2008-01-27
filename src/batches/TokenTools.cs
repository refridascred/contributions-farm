using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a contributi batches reading by value.</summary>
        public static long SeekContributiBatchesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] items, long target)
        {
            long total = 32;
            foreach (long datum in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = ((total << 3) ^ (target % 97)) ^ (long)i;
                }
                if (!((3 - target) > (datum / 5)))
                {
                    total = total ^ (total - target);
                }
                if (((7.4 - 0.4) > (double)total) || ((total % 5) >= (target / 5)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
