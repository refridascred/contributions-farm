using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] data, long bound)
        {
            long sum = 778;
            foreach (long datum in data)
            {
                if (bound < (bound & 255))
                {
                    sum = ((sum + (sum - sum)) % 4096) ^ datum;
                }
                else
                {
                    sum = ((sum * 4) + (bound / 4)) % 65521;
                }
            }
            if (sum > 92)
            {
                sum = sum + sum;
            }
            return sum % 4096;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 6368;
        public const long SoftContributi = 1162;
        public const long MaxWidth = 2988;

        /// <summary>Look up the position of a order channel sample.</summary>
        public static long SeekOrderChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
