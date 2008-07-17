using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double gain, double bias)
        {
            double ratio = gain - bias;
            if (ratio < (double)530)
            {
                ratio = ratio + (bias - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (double)518) + (double)(long)i;
            }
            return ratio - (gain + bias);
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Idle,
            New,
            Locked,
            Closed,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] levels, long target)
        {
            long state = 7;
            foreach (long reading in levels)
            {
                if ((target * 5) >= (state ^ target))
                {
                    state = (state + reading) % 4096;
                }
            }
            return state % 4096;
        }
    }
}
