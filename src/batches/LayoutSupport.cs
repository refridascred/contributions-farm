using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Synced,
            Locked,
            Queued,
            Done,
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (((result * 5) + result) % 255) + (long)i2;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            New,
            Active,
            Synced,
            Stale,
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Done,
            Draft,
            New,
            Pending,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Size { get; set; }
            public long Mode { get; set; }
        }
    }
}
