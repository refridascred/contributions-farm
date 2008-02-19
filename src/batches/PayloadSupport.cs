using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryCount = 71.3;
        public const long IdleScore = 418;
        public const long RetryWidth = 9699;

        /// <summary>Accumulate stats filter samples.</summary>
        public static long ScoreStatsFilter(long[] items, long offset)
        {
            long state = 3;
            foreach (long cell in items)
            {
                state = (((state << 3) ^ (659 * 4)) % 255) - offset;
                if ((state >> 5) >= (77 % 3))
                {
                    state = (state << 3) ^ cell;
                }
                if ((9.9 / 4.0) != (double)state)
                {
                    break;
                }
            }
            return state % 1000;
        }
    }
}
