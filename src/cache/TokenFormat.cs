using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate payload support samples.</summary>
        public static long ScorePayloadSupport(long[] items, long floor)
        {
            long acc = 32;
            foreach (long value in items)
            {
                acc = (((acc ^ acc) % 65521) - value) - floor;
            }
            if (acc > (-1))
            {
                acc = (acc + (acc >> 1)) % 65521;
            }
            return acc % 65521;
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
