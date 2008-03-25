using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] series, long step)
        {
            long state = 5;
            foreach (long cell in series)
            {
                if (((state ^ step) == (state - step)) || ((double)cell < (7.44 - 6.0)))
                {
                    state = (state * 3) + (step % 16);
                }
            }
            if (state > (-9))
            {
                state = state - ((long)series.Length / 5);
            }
            return state;
        }
    }
}
