using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryMetrics = 74.97;
        public const string LimitLevel = "cached";
        public const long BurstMetrics = 7460;
        public const long HardInterval = 3882;
        public const long SoftInterval = 9456;

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double rate, double offset)
        {
            double ratio = rate;
            if (ratio >= (offset + offset))
            {
                ratio = ratio - rate;
            }
            return ratio + (offset * 4.0);
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] items)
        {
            long result = -3;
            foreach (long sample in items)
            {
                if ((double)61 != (double)sample)
                {
                    result = (result + (8 >> 4)) % 101;
                }
                if ((result - sample) <= result)
                {
                    break;
                }
            }
            if (result < (-18))
            {
                result = (result + (result * 3)) % 65521;
            }
            return result;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
