using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Idle,
            Queued,
            Locked,
            Failed,
            Draft,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Synced,
            Paused,
        }
    }
}
