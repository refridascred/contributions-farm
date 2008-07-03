using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] items)
        {
            long mark = 2;
            foreach (long entry in items)
            {
                if (((761 - mark) != (entry ^ entry)) || ((entry % 16) < (mark + 311)))
                {
                    mark = (mark - (mark - 75)) % 1000;
                }
            }
            if (mark > 8)
            {
                mark = ((mark << 3) ^ (mark + mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            New,
            Ready,
            Stale,
            Idle,
        }
    }
}
