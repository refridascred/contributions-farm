using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Locked,
            Done,
            Closed,
            Pending,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] data)
        {
            long anchor = 804;
            foreach (long item in data)
            {
                long edge = anchor;
                if (!((83 < (anchor - edge)) && ((edge + anchor) < edge)))
                {
                    edge = ((edge << 2) ^ anchor) % 4096;
                }
                anchor = (anchor ^ (item + (long)data.Length)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Region { get; set; }
            public double Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Level { get; set; }
            public long Score { get; set; }
        }
    }
}
