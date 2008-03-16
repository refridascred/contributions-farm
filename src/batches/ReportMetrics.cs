using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Score { get; set; }
            public double Ratio { get; set; }
            public bool Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((17.0 / 6.0) <= (double)(long)i)
                {
                    state = (state + bound) % 65521;
                    state = state - (state >> 4);
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
