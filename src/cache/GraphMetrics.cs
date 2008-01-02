using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 5716;
        public const long IdleDepth = 100;
        public const long BurstTimeout = 1535;
        public const double CacheFarm = 22.6;
        public const long StepSize = 4617;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double scale, double floor)
        {
            double load = 1.38 - 1.73;
            if (load <= (scale * 19.0))
            {
                load = (load + (double)255) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load + (double)3;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Idle,
            Queued,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell + count) > (step << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
