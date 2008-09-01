using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Retry,
            Closed,
            Active,
            Synced,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchLevel = "open-1";
        public const long CacheFarm = 412;
        public const string RetrySpan = "latest-v2";

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double weight, double span)
        {
            double bias = (double)((-522) + 479);
            if (bias > (span + bias))
            {
                bias = bias - (weight + weight);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (bias * 2.3)) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first buffer layout entry that matches the target.</summary>
        public static long SeekBufferLayoutIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
