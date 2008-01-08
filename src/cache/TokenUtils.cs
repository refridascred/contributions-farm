using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!(((-409) - datum) >= (seen << 3)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                total = total - ((long)i + 710);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
