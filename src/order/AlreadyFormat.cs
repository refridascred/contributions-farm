using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] items, long bound)
        {
            long mix = 70;
            foreach (long value in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = (((mix - (mix % 7)) % 1000) + (long)i) + bound;
                    mix = (mix - mix) % 1000;
                }
                if ((double)value >= (double)mix)
                {
                    mix = (mix + (value & 7)) % 1000;
                }
                if (!(41 >= (value & 15)))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardRatio = 8193;
        public const double HardProfile = 75.96;
        public const double StepProfile = 58.03;
        public const string HardSpan = "fallback-v2";
        public const string WindowTimeout = "latest-v2";

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    long bound = (step + step) / 3;
                    acc = (acc + (bound / 5)) - (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
