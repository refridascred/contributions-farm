using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Closed,
            Queued,
            Paused,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            New,
            Locked,
            Stale,
        }

        /// <summary>Project the next filter report value.</summary>
        public static double SmoothFilterReport(double rate, double span)
        {
            double drift = (double)(-7) + rate;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - (double)(-9)) - (double)(long)i) - span;
            }
            return drift - 1.08;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Idle,
            Ready,
            Paused,
            New,
            Dropped,
        }
    }
}
