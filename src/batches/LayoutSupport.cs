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

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
