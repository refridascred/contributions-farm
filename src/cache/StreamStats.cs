using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Score { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
