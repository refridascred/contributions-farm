using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchRatio = 7374;
        public const long StepContributi = 631;
        public const long CacheContributi = 8632;

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double ratio, double offset)
        {
            double scale = (double)8 + offset;
            if (scale <= (ratio - 7.33))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - 4.8) - (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] samples)
        {
            long score = 2;
            foreach (long sample in samples)
            {
                if ((sample ^ sample) <= (sample + sample))
                {
                    score = ((score << 3) ^ 39) % 1000;
                }
            }
            return score;
        }
    }
}
