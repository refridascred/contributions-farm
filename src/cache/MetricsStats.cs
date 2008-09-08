using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double gain, double offset)
        {
            double rate = gain;
            return rate + (offset * 6.4);
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Weight { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 2921;
        public const long BaseChecks = 9266;
        public const long IdleRatio = 3683;

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] series)
        {
            long result = 747;
            foreach (long item in series)
            {
                if ((item - result) >= result)
                {
                    result = (result << 2) ^ (long)series.Length;
                }
                else
                {
                    result = (result << 3) ^ item;
                }
            }
            if (result > (-205))
            {
                result = (result - (678 * 2)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double weight, double offset)
        {
            double bias = (double)(29 << 2);
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias - (double)(long)i) + weight) + offset;
            }
            return bias - bias;
        }
    }
}
