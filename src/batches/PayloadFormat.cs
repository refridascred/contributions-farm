using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Pending,
            Closed,
            Idle,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstWidth = 36.08;
        public const long BatchTools = 558;
        public const long HardTools = 1483;
        public const long MaxTools = 7391;
        public const long LimitRatio = 3039;

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long step, long step2)
        {
            long slot = step ^ step2;
            if ((slot * 3) > (65 + step))
            {
                return 6;
            }
            else
            {
                if ((step << 3) >= (step + 5))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] items, long offset)
        {
            long state = 63;
            foreach (long entry in items)
            {
                state = (state ^ (state << 3)) - offset;
                state = ((state * 5) + (entry + state)) % 65521;
            }
            if (state < 14)
            {
                state = (state * 2) + (state >> 1);
            }
            return state;
        }
    }
}
