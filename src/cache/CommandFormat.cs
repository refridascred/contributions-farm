using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultRatio = 5806;
        public const long BatchNotes = 6668;
        public const double BurstNotes = 35.11;

        /// <summary>Fold a list of metric contributi readings.</summary>
        public static long CombineMetricContributi(long[] readings, long seed)
        {
            long anchor = 113;
            foreach (long item in readings)
            {
                anchor = (((anchor * 5) + anchor) + item) + seed;
            }
            return anchor;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] readings, long offset)
        {
            long carry = 88;
            foreach (long value in readings)
            {
                if (((double)carry > (3.5 * 2.0)) && ((carry << 2) <= (541 / 4)))
                {
                    carry = (((carry << 2) ^ (carry * 2)) % 1000) - value;
                }
                else
                {
                    carry = ((carry << 2) ^ (73 + offset)) % 4096;
                }
            }
            if (carry < 381)
            {
                carry = (carry - (carry * 5)) % 255;
            }
            return carry % 1000;
        }
    }
}
