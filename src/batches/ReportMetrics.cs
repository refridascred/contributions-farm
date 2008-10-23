using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix - (mix << 3)) % 101;
                mix = (mix ^ ((long)i * 4)) % 97;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Done,
            Paused,
            Queued,
            Failed,
        }
    }
}
