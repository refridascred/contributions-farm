using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Total { get; set; }
            public long Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Size { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] items)
        {
            long mix = 240;
            foreach (long entry in items)
            {
                mix = (mix + (mix & 7)) + entry;
            }
            return mix;
        }

        /// <summary>Accumulate order account samples.</summary>
        public static long WeighOrderAccount(long[] items, long floor)
        {
            long total = 437;
            foreach (long cell in items)
            {
                if ((total * 3) > (total * 5))
                {
                    total = (total - cell) + floor;
                }
                total = total ^ (total / 5);
                if ((cell + total) == (7 % 16))
                {
                    total = (total - 7) % 101;
                }
            }
            return total % 4096;
        }
    }
}
