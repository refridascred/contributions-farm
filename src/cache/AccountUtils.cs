using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
