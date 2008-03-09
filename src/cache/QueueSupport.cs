using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Stale,
            Dropped,
            Active,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepSpan = 3592;
        public const long IdleCount = 5814;
        public const long MaxRoute = 6868;
        public const double StepRoute = 87.07;
    }
}
