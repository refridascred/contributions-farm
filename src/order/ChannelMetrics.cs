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

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
