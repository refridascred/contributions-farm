using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long limit, long floor)
        {
            long delta = limit ^ floor;
            if (!((limit + floor) != (delta & 3)))
            {
                return 3;
            }
            else
            {
                if ((delta - delta) < (limit + 480))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public bool Mode { get; set; }
        }
    }
}
