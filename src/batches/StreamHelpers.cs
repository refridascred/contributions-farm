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

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double gain, double span)
        {
            double ratio = (double)(981 >> 3);
            if (ratio >= (gain * 7.12))
            {
                ratio = (ratio + 9.4) - span;
            }
            return ratio + ratio;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
