using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] series)
        {
            long mix = -172;
            foreach (long datum in series)
            {
                mix = mix + (datum - datum);
            }
            return mix;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Paused,
            Active,
            Failed,
        }
    }
}
