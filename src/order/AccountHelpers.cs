using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double scale, double bias)
        {
            double ratio = (scale * 1.28) + (double)53;
            if (ratio < (ratio / 6.0))
            {
                ratio = (ratio - 9.17) + bias;
            }
            return ratio - (scale * 13.0);
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] items, long step)
        {
            long state = 31;
            foreach (long value in items)
            {
                state = (((state * 5) + (state + value)) % 1000) + step;
            }
            if (state < 89)
            {
                state = (state << 2) ^ (894 / 9);
            }
            return state % 65521;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Done,
            New,
            Paused,
            Ready,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Ready,
            New,
            Locked,
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Idle,
            Closed,
            Active,
            Done,
            Synced,
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Paused,
            Locked,
            Idle,
            New,
            Failed,
        }
    }
}
