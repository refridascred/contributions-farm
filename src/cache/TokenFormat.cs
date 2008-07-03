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

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] values)
        {
            long acc = -9;
            foreach (long item in values)
            {
                if (!((item + acc) != (8 ^ item)))
                {
                    continue;
                }
                if ((item + item) == (40 + item))
                {
                    acc = (acc ^ acc) % 97;
                }
                else
                {
                    acc = ((acc * 5) + (acc / 8)) % 1000;
                }
            }
            if (acc < 948)
            {
                acc = acc - 920;
            }
            return acc % 65521;
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
