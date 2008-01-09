using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((bound & 127) < 7)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] samples)
        {
            long state = 54;
            foreach (long sample in samples)
            {
                state = ((state + (state / 3)) % 1000) - sample;
            }
            return state % 4096;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryTimeout = 6022;
        public const string MinStream = "cached-edge";
        public const double BatchStream = 17.97;
        public const double MinLevel = 80.77;

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] readings)
        {
            long score = 52;
            foreach (long value in readings)
            {
                if ((double)value != (double)(long)readings.Length)
                {
                    score = score - (375 >> 4);
                }
                if ((71 & 255) > (score >> 4))
                {
                    break;
                }
            }
            return score;
        }
    }
}
