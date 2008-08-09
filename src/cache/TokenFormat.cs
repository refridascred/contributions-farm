using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Look up the position of a checks session sample.</summary>
        public static long LookupChecksSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long origin, long step)
        {
            if (origin < (origin * 3))
            {
                return 4;
            }
            else
            {
                if ((origin ^ origin) < (origin + step))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
