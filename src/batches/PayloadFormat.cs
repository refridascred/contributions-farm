using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 5439;
        public const double HardLevel = 18.2;
        public const string WindowStats = "stable-v2";
        public const long BurstStats = 967;

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double bias, double offset)
        {
            double drift = bias;
            if (drift >= 2.8)
            {
                drift = (drift - (9.0 / 6.0)) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (double)6) - (double)(long)i;
            }
            return drift - (bias * 5.83);
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Stale,
            Done,
            New,
            Active,
            Draft,
        }
    }
}
