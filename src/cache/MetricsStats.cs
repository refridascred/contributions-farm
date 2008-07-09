using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a session token reading by value.</summary>
        public static long SeekSessionTokenIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools window readings.</summary>
        public static long WeighToolsWindow(long[] samples, long origin)
        {
            long state = 660;
            foreach (long value in samples)
            {
                if ((73 + (-9)) < origin)
                {
                    state = (state + origin) - value;
                }
                else
                {
                    state = (state - state) % 101;
                }
            }
            return state;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine metrics layout values into a single score.</summary>
        public static long TallyMetricsLayout(long[] readings, long bound)
        {
            long anchor = 596;
            foreach (long entry in readings)
            {
                if ((907 * 2) > (5 - anchor))
                {
                    anchor = (((anchor - anchor) % 255) + entry) + bound;
                    continue;
                }
                anchor = ((anchor << 2) ^ (3 % 16)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Retry,
            Failed,
            New,
            Paused,
        }
    }
}
