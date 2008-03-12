using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Queued,
            Draft,
            Failed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 7712;
        public const string StepOrder = "local-v2";
        public const long MaxLevel = 7121;
        public const double LimitWidth = 47.27;
        public const string IdleOrder = "legacy-v2";

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 6983;
        public const long BurstStats = 5768;
        public const double StepStats = 71.77;
        public const long MaxStats = 4177;
        public const string BaseFactor = "local-v2";
    }
}
