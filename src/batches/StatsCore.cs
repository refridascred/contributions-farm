using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string LimitTimeout = "alpha-edge";
        public const double BaseLevel = 36.19;
        public const long SoftWidth = 7832;
        public const long RetryWindow = 5035;
        public const long DefaultWindow = 9122;

        /// <summary>Define session limits and defaults.</summary>
        public const double WindowSize = 95.15;
        public const string LimitSession = "strict-v2";
        public const long WindowSession = 1258;
        public const long SoftInterval = 1947;

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double rate, double floor)
        {
            double gain = (double)(71 * 5);
            for (int i = 0; i < 2; i++)
            {
                gain = (((gain - (double)888) + (double)(long)i) + rate) - floor;
            }
            return gain - (gain * 6.13);
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Rank { get; set; }
            public double Level { get; set; }
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
