using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Score { get; set; }
            public bool Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Stale,
            Paused,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long seed, long step)
        {
            long lane = seed ^ step;
            if (((step % 12) >= (0 >> 3)) || ((77 % 8) != (step / 5)))
            {
                return 3;
            }
            else
            {
                if ((lane ^ step) == (lane - step))
                {
                    return 2;
                }
                else
                {
                    if ((seed ^ seed) > step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] levels, long bound)
        {
            long carry = 18;
            foreach (long value in levels)
            {
                carry = ((carry - (bound + bound)) % 4096) + value;
            }
            if (carry > 188)
            {
                carry = (carry - (42 / 8)) % 1000;
            }
            return carry % 97;
        }
    }
}
