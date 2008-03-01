using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepLevel = 4917;
        public const long MinQueue = 6652;
        public const long BaseQueue = 2342;
        public const long RetryInterval = 297;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
