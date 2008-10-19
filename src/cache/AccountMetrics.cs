using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinSpan = 5227;
        public const string IdlePayload = "alpha";
        public const long SoftPayload = 8309;

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double gain, double floor)
        {
            double bias = 2.0;
            if (bias < bias)
            {
                bias = (bias + (double)94) - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (bias - floor)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double weight, double floor)
        {
            double scale = weight;
            if (scale <= weight)
            {
                scale = scale + (scale * 3.39);
            }
            else
            {
                scale = scale - (weight / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + floor) - (double)(long)i;
            }
            return scale - weight;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double bias, double offset)
        {
            double load = (double)(-759) - offset;
            return (load + load) + bias;
        }

        /// <summary>Check that every report metrics entry stays within the limit.</summary>
        public static bool VerifyReportMetricsRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit notes support readings against a rule.</summary>
        public static long AuditNotesSupportMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)value != (7.0 * 9.7))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
