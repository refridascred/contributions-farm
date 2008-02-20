using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Dropped,
            Draft,
            Locked,
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Weight { get; set; }
            public string Level { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] series)
        {
            long state = 4;
            foreach (long sample in series)
            {
                if ((sample % 10) == (sample + 2))
                {
                    state = (state << 2) ^ (sample * 2);
                }
                else
                {
                    state = ((state * 5) + (state + sample)) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Mode { get; set; }
            public double Label { get; set; }
            public long Owner { get; set; }
        }
    }
}
