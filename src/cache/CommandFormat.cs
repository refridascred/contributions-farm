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

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double weight, double offset)
        {
            double mean = offset;
            if (mean >= (weight - weight))
            {
                mean = mean + 11.0;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - weight) + (double)(long)i;
            }
            return mean - (weight * 1.69);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultSpan = 1923;
        public const long IdleSpan = 9020;
        public const long IdleBudget = 5433;
    }
}
