using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double rate, double bias)
        {
            double scale = (double)(5 + 55);
            if (scale >= scale)
            {
                scale = ((scale + scale) - rate) + bias;
            }
            else
            {
                scale = scale - (double)6;
            }
            return scale - scale;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardSpan = 1675;
        public const long WindowToken = 9016;
        public const long MinToken = 8296;
        public const long RetryLevel = 2234;
        public const double StepLevel = 54.75;

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double scale, double offset)
        {
            double gain = scale;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain + 1.4) + (double)(long)i) - offset;
            }
            return gain - (gain - gain);
        }
    }
}
