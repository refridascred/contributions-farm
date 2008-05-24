using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next contributi batch value from a seed.</summary>
        public static long DeriveContributiBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                if (((47 - 42) > (total + (-8))) || (limit <= (limit + limit)))
                {
                    break;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryInterval = 48.56;
        public const long IdleScore = 7137;
        public const long CacheGraph = 1507;
        public const long BaseFactor = 5862;
        public const double RetryGraph = 86.43;

        /// <summary>Compare every pair of command context readings.</summary>
        public static long PairCommandContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long target)
        {
            long state = target;
            for (int i = 0; i < 13; i++)
            {
                if ((long)i >= state)
                {
                    state = (state ^ ((long)i / 2)) % 101;
                    state = state - (target & 127);
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
