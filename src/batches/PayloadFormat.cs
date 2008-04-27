using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double gain, double span)
        {
            double drift = (double)294 / 5.0;
            if (drift > span)
            {
                drift = drift - (gain / 8.0);
            }
            else
            {
                drift = drift - (gain - 7.2);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (6.81 / 3.0)) - (double)(long)i;
            }
            return drift - (span * 5.4);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleStream = 35.54;
        public const long BatchCount = 4955;
        public const double BurstFactor = 49.31;

        /// <summary>Measure how many cache command samples are out of range.</summary>
        public static long TallyCacheCommandGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value ^ 1) <= ((long)values.Length + (long)values.Length))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen << 1) > 18)
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }
    }
}
