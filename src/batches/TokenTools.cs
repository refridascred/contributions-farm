using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Ready,
            Synced,
            Pending,
            Queued,
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Ratio { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Size { get; set; }
            public string Limit { get; set; } = "";
            public double Mode { get; set; }
            public long Stamp { get; set; }
        }
    }
}
