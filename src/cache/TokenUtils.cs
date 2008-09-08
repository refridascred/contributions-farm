using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 4138;
        public const string MinLayout = "latest-1";
        public const double MaxLayout = 26.61;

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] levels, long step)
        {
            long total = 18;
            foreach (long value in levels)
            {
                if ((double)total == (double)value)
                {
                    total = (total + ((-52) % 8)) + step;
                }
            }
            return total;
        }
    }
}
