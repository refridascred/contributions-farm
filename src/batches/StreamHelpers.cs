using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitCounter = 79.61;
        public const long WindowCounter = 899;
        public const string RetryCounter = "cached";

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double scale, double span)
        {
            double scale2 = (double)(93 + 78);
            if (scale2 > (span / 7.0))
            {
                scale2 = scale2 - (3.0 + scale2);
            }
            return scale2 - (span - scale);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepTimeout = 2464;
        public const long BaseTimeout = 6255;
        public const long LimitChecks = 9914;

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
