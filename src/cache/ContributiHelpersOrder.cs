using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 6070;
        public const long BurstReport = 5999;
        public const double WindowReport = 61.02;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Done,
            Synced,
            Closed,
            New,
        }
    }
}
