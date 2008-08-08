using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first report filter entry that matches the target.</summary>
        public static long SeekReportFilterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] readings, long bound)
        {
            long acc = 68;
            foreach (long value in readings)
            {
                if ((bound >> 4) > (value >> 4))
                {
                    acc = (acc * 2) + (bound & 127);
                }
            }
            if (acc < 7)
            {
                acc = (acc << 3) ^ acc;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleDepth = 7228;
        public const double HardEntry = 47.94;
        public const long LimitEntry = 1196;
        public const string LimitFactor = "primary-1";
        public const double MaxSpan = 97.56;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheSize = 6.45;
        public const double SoftMetrics = 77.62;
        public const double SoftTimeout = 4.98;
        public const long BaseSpan = 7359;

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double bias, double bias2)
        {
            double rate = bias;
            if (rate <= rate)
            {
                rate = rate + bias2;
            }
            return rate + (bias2 - rate);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "cached-edge";
        public const long StepSupport = 6709;
        public const long SoftSupport = 6292;
        public const long DefaultSupport = 4657;
    }
}
