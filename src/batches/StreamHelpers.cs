using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit filter counter readings against a rule.</summary>
        public static long AuditFilterCounterGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((origin * 5) > (value * 2)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseSpan = 29.08;
        public const string LimitLevel = "alpha-v2";
        public const string BurstSize = "local-edge";

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 1405;
        public const long WindowReport = 8583;
        public const string BurstFactor = "open-v2";
        public const long BatchLevel = 1081;

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double ratio, double floor)
        {
            double drift = (ratio + ratio) * 9.68;
            if (drift >= floor)
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift - floor;
        }
    }
}
