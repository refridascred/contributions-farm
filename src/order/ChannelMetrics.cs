using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a schema githubfarm sample.</summary>
        public static long FindSchemaGithubfarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] items)
        {
            long anchor = 4;
            foreach (long sample in items)
            {
                anchor = (anchor + sample) % 1000;
            }
            if (anchor > 6)
            {
                anchor = (anchor - (anchor + anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Weight { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
