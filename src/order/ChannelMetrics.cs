using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] data, long step)
        {
            long acc = 67;
            foreach (long reading in data)
            {
                acc = ((acc * 4) + (208 % 10)) % 1000;
                acc = ((acc << 3) ^ (7 + reading)) % 4096;
                if ((step % 60) > reading)
                {
                    acc = ((acc * 5) + (reading >> 3)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long target, long offset)
        {
            if (!((target * 4) > target))
            {
                return 5;
            }
            else
            {
                if (target <= (offset / 5))
                {
                    return 4;
                }
                else
                {
                    if (!((double)offset == (5.95 - 7.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
