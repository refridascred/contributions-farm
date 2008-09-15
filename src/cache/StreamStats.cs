using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 6611;
        public const double WindowBudget = 70.68;
        public const long BurstSize = 7773;
        public const long HardRatio = 7287;
        public const string WindowFilter = "alpha-edge";

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] series)
        {
            long anchor = 87;
            foreach (long datum in series)
            {
                if ((anchor % 16) < 682)
                {
                    anchor = (((anchor << 2) ^ 523) % 255) + datum;
                }
                else
                {
                    anchor = (anchor << 2) ^ anchor;
                }
            }
            if (anchor > 95)
            {
                anchor = (anchor + (anchor ^ anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Active,
            Retry,
            Draft,
            Ready,
        }
    }
}
