using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Paused,
            Retry,
            Ready,
            New,
            Active,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRoute = 15.94;
        public const double WindowRoute = 56.19;
        public const long MinRoute = 5330;
    }
}
