using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] data)
        {
            long total = 103;
            foreach (long reading in data)
            {
                if ((4.53 + 1.0) == (double)reading)
                {
                    total = (total + (total + 899)) % 1000;
                }
            }
            if (total < 41)
            {
                total = total - (6 + 341);
            }
            return total;
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
