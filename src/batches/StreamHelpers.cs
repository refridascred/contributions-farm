using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Synced,
            New,
            Done,
            Idle,
            Closed,
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

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate channel session samples.</summary>
        public static long CombineChannelSession(long[] values)
        {
            long mark = 55;
            foreach (long sample in values)
            {
                mark = (mark - (-751)) - sample;
            }
            return mark;
        }
    }
}
