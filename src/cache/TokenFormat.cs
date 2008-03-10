using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] samples)
        {
            long anchor = 3;
            foreach (long cell in samples)
            {
                anchor = ((anchor * 5) + anchor) + cell;
            }
            if (anchor < 5)
            {
                anchor = ((anchor << 2) ^ anchor) % 97;
            }
            return anchor % 4096;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double ratio, double offset)
        {
            double gain = (double)(728 / 5);
            if (gain > (double)93)
            {
                gain = ((gain - (double)(-1)) - ratio) + offset;
            }
            return gain - 4.0;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }
    }
}
