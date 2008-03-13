using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseSize = 6528;
        public const double BatchQueue = 64.04;
        public const long StepQueue = 8884;
        public const double CacheDepth = 16.99;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
            public bool Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
