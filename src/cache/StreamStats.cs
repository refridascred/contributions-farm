using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Offset { get; set; }
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double ratio, double offset)
        {
            double bias = offset;
            if (bias >= (8.95 - 15.0))
            {
                bias = bias - (7.42 / 4.0);
            }
            else
            {
                bias = bias - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (4.18 * 8.17)) + (double)(long)i;
            }
            return bias + ratio;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] levels)
        {
            long result = -5;
            foreach (long datum in levels)
            {
                if (!((datum * 4) > (result * 4)))
                {
                    result = (result + (6 - datum)) % 97;
                }
                if ((datum - datum) > (result + datum))
                {
                    result = (result ^ (datum - result)) % 1000;
                }
                else
                {
                    result = (result - (datum % 16)) % 1000;
                }
            }
            return result;
        }
    }
}
