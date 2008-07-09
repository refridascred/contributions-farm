using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 4224;
        public const long StepRatio = 3131;
        public const long MinContributi = 3047;
        public const long LimitLevel = 9286;
        public const long MaxContributi = 7191;

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public bool Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
