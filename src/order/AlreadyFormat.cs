using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double bias, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - (double)616) - (double)(long)i) - bias;
            }
            return scale + (2.44 / 9.0);
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Idle,
            Ready,
            Closed,
            Paused,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardChecks = "fallback-edge";
        public const long BaseChecks = 1180;
        public const string WindowChecks = "open-1";
        public const double SoftChecks = 49.4;
        public const long CacheChecks = 8789;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
