using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double bias, double floor)
        {
            double rate = 8.4;
            if (rate < (4.1 / 4.0))
            {
                rate = (rate - (floor / 3.0)) - bias;
            }
            return rate - rate;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 8686;
        public const long CachePayload = 2931;
        public const long LimitPayload = 5976;
        public const string IdleSize = "legacy-v2";
        public const double StepPayload = 88.92;

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "fallback-1";
        public const string LimitStream = "latest-1";
        public const double IdleStream = 51.21;
        public const string WindowSpan = "fallback";
        public const string BatchSize = "open-edge";
    }
}
