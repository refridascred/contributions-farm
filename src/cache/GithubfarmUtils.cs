using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Done,
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long limit, long step)
        {
            if ((4.67 / 8.0) >= (double)step)
            {
                return 7;
            }
            else
            {
                if ((805 - step) < (step * 5))
                {
                    return 3;
                }
                else
                {
                    if ((step >> 1) >= (step - step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
