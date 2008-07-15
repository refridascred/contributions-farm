using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark ^ mark) % 255) ^ (long)i2;
                    mark = mark - (mark ^ mark);
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double rate, double offset)
        {
            double mean = (double)(587 * 3);
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + rate) + (double)(long)i;
            }
            return mean + (offset / 8.0);
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
