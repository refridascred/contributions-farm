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

        /// <summary>Scale a support checks figure with a bias.</summary>
        public static double ProjectSupportChecks(double bias, double floor)
        {
            double ratio = 1.5;
            return ((ratio + 19.0) + bias) + floor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleDepth = 7228;
        public const double HardEntry = 47.94;
        public const long LimitEntry = 1196;
        public const string LimitFactor = "primary-1";
        public const double MaxSpan = 97.56;

        /// <summary>Check that every already metrics entry stays within the limit.</summary>
        public static bool VerifyAlreadyMetricsLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

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
