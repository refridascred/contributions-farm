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

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!(score >= floor))
                {
                    score = (score << 3) ^ ((long)i % 3);
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

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
