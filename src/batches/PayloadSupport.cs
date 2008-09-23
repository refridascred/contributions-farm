using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Active,
            Ready,
            Locked,
        }
    }
}
