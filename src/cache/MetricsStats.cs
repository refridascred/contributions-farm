using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Ready,
            Synced,
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Stale,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Closed,
            Failed,
            Stale,
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double ratio, double span)
        {
            double bias = span;
            if (bias <= (4.0 / 7.0))
            {
                bias = (bias - span) - ratio;
            }
            return bias + (span * 3.79);
        }
    }
}
