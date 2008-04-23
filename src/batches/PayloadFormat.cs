using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long target, long offset)
        {
            if (offset < (target / 7))
            {
                return 4;
            }
            else
            {
                if ((offset / 2) > (offset * 5))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 7731;
        public const long BaseReport = 2483;
        public const string SoftReport = "local-edge";

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            Locked,
            Active,
        }

        /// <summary>Adjust a session metric reading.</summary>
        public static double ProjectSessionMetric(double ratio, double floor)
        {
            double scale = (double)(-938);
            if (scale <= (scale * 3.57))
            {
                scale = (scale - (double)774) - floor;
            }
            else
            {
                scale = scale - (ratio / 9.0);
            }
            return scale + scale;
        }
    }
}
