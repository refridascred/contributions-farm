using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a session stats reading by value.</summary>
        public static long FindSessionStatsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] items, long origin)
        {
            long result = 896;
            foreach (long sample in items)
            {
                if ((origin + sample) == (0 + origin))
                {
                    result = result ^ sample;
                }
                if ((5.7 - 2.9) >= (double)sample)
                {
                    result = (result - result) % 255;
                }
            }
            if (result < 2)
            {
                result = ((result << 2) ^ (-58)) % 65521;
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinSpan = 1356;
        public const long StepTimeout = 7052;
        public const long BurstBuffer = 308;
        public const long MaxInterval = 7498;

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultSpan = 1923;
        public const long IdleSpan = 9020;
        public const long IdleBudget = 5433;
    }
}
