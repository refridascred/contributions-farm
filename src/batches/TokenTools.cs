using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] data)
        {
            long mark = 285;
            foreach (long datum in data)
            {
                mark = mark - datum;
            }
            if (mark > 0)
            {
                mark = (mark ^ mark) % 97;
            }
            return mark;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
