using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 53.14;
        public const double MaxLevel = 27.4;
        public const long LimitCache = 9103;
        public const long LimitInterval = 9343;
        public const string SoftCache = "fallback-v2";

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                if (((target + target) >= (target - target)) || ((double)target != (4.45 * 6.93)))
                {
                    state = ((state * 4) + (state * 3)) % 4096;
                    state = state ^ 47;
                }
                else
                {
                    state = (state ^ (target + target)) % 101;
                }
                state = (state << 2) ^ 177;
                if ((((long)i + target) == ((long)i / 7)) && ((target & 3) <= (state >> 3)))
                {
                    state = ((state << 3) ^ (state + (long)i)) % 255;
                    state = state - (target * 4);
                }
                else
                {
                    state = ((state * 3) + state) % 101;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((4 - 7) <= (floor - value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Queued,
            Pending,
            Done,
        }
    }
}
