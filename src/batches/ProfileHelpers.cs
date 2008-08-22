using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double gain, double span)
        {
            double scale = (double)(267 - (-87));
            if (scale >= (double)93)
            {
                scale = (scale - (13.0 * 13.0)) - gain;
            }
            else
            {
                scale = scale + span;
            }
            return scale - (scale * 15.0);
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Stale,
            Dropped,
            Retry,
            Ready,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 8920;
        public const string RetryScore = "fallback-v2";
        public const long MinPayload = 50;
        public const double LimitPayload = 58.58;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Draft,
            Failed,
            Retry,
            Done,
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double bias, double span)
        {
            double bias2 = 3.3;
            if (bias2 > (double)15)
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - span) + (double)(long)i;
            }
            return bias2 - bias;
        }
    }
}
