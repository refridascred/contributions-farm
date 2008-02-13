using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Level { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Stamp { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Iterate the filter context series from a seed.</summary>
        public static long SeriesFilterContext(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum - (85 + 574)) % 4096;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] data)
        {
            long state = 793;
            foreach (long cell in data)
            {
                state = ((state << 3) ^ (state + 51)) - cell;
            }
            return state;
        }
    }
}
