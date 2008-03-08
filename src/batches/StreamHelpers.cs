using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Stale,
            Done,
            Queued,
            Pending,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BatchBuffer = 78.33;
        public const long DefaultBuffer = 7346;
        public const long HardBuffer = 8875;
        public const string WindowBuffer = "cached-1";
        public const long BatchScore = 4886;

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 3095;
        public const double IdleSize = 48.94;
        public const string SoftWidth = "stable-v2";
        public const long MaxAlready = 5595;
        public const long WindowAlready = 1424;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Retry,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double weight, double span)
        {
            double gain = (double)(74 - 3);
            if (gain <= gain)
            {
                gain = gain - span;
            }
            else
            {
                gain = gain + 7.17;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (gain + span)) + (double)(long)i;
            }
            return gain + (span + weight);
        }
    }
}
