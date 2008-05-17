using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Weight { get; set; }
            public double Score { get; set; }
            public double Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i * 5) >= (long)i)
                {
                    acc = (acc + 5) % 4096;
                    acc = acc ^ target;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
