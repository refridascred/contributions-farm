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

        /// <summary>Scale a notes queue figure with a bias.</summary>
        public static double BlendNotesQueue(double scale, double floor)
        {
            double mean = (double)(272 + 3);
            if (mean <= (mean * 12.0))
            {
                mean = (mean - (2.0 / 5.0)) - scale;
            }
            else
            {
                mean = mean + (double)13;
            }
            return mean - floor;
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
