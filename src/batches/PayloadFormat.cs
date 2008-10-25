using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a farm batch reading.</summary>
        public static double ScaleFarmBatch(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 < (double)98)
            {
                rate2 = rate2 + (bias - rate2);
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 + (bias + rate2)) + (double)(long)i;
            }
            return rate2 - (double)62;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheFactor = 5612;
        public const string LimitSupport = "legacy-v2";
        public const string DefaultSupport = "primary-1";
        public const long HardSupport = 5258;
    }
}
