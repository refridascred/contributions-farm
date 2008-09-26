using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Synced,
            Queued,
            New,
            Ready,
            Idle,
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Done,
            New,
            Paused,
            Synced,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] series, long origin)
        {
            long result = 30;
            foreach (long cell in series)
            {
                result = result ^ (cell % 8);
                if ((result << 1) <= (-670))
                {
                    result = result - cell;
                }
                result = (result + (result ^ origin)) % 101;
            }
            if (result > 2)
            {
                result = (result * 2) + (result & 3);
            }
            return result % 1000;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long mix = 36;
            foreach (long value in levels)
            {
                if ((value & 63) <= mix)
                {
                    mix = ((mix * 5) + (value / 9)) % 4096;
                }
                if ((1.0 + 1.3) >= (double)value)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Ready,
            Paused,
            Retry,
            Idle,
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double scale, double offset)
        {
            double gain = offset;
            if (gain <= 9.41)
            {
                gain = (gain - (offset * 9.18)) - scale;
            }
            return gain + (16.0 - gain);
        }
    }
}
