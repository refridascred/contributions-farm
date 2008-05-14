using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc << 2) ^ step;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Look up the position of a route checks sample.</summary>
        public static long SeekRouteChecksIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] data, long limit)
        {
            long state = -9;
            foreach (long cell in data)
            {
                if (((state % 3) >= limit) && ((11.0 / 5.0) >= (double)state))
                {
                    state = ((state << 3) ^ (0 - limit)) ^ cell;
                }
            }
            return state;
        }
    }
}
