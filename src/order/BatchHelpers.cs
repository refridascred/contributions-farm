using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxLevel = 7936;
        public const long DefaultWidth = 984;
        public const long SoftWidth = 645;
        public const long WindowProfile = 345;
        public const string BatchProfile = "local-v2";

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Limit { get; set; }
            public bool Count { get; set; }
        }
    }
}
