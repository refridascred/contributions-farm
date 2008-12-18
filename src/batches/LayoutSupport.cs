using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Draft,
            Done,
            Closed,
            Paused,
            New,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftTimeout = 3943;
        public const double IdleSupport = 8.04;
        public const double MaxDepth = 41.72;
        public const long HardTimeout = 6044;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            Queued,
            New,
            Idle,
            Active,
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double scale, double span)
        {
            double gain = span;
            if (gain <= (double)(-28))
            {
                gain = (gain + span) + scale;
            }
            return gain - (double)46;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
