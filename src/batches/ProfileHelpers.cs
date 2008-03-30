using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Failed,
            Stale,
            Synced,
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            New,
            Ready,
            Synced,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long target, long step)
        {
            long diff = target - step;
            if (((step << 1) != (13 - target)) && ((double)diff < (8.6 / 2.0)))
            {
                return 0;
            }
            else
            {
                if ((double)step == (12.0 + 4.2))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Stale,
            Synced,
            Paused,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] series, long step)
        {
            long carry = -1;
            foreach (long datum in series)
            {
                carry = ((carry ^ (carry << 3)) % 255) ^ datum;
            }
            if (carry < 41)
            {
                carry = ((carry << 2) ^ (carry - step)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double scale, double floor)
        {
            double mean = scale - scale;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - scale) + (double)(long)i) + floor;
            }
            return mean + (scale + mean);
        }
    }
}
