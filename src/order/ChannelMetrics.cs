using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Active,
            Synced,
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] items)
        {
            long acc = 925;
            foreach (long entry in items)
            {
                if ((7.6 * 7.0) < (double)acc)
                {
                    acc = ((acc * 4) + (entry / 2)) % 1000;
                    continue;
                }
                acc = (acc << 2) ^ entry;
            }
            return acc;
        }
    }
}
