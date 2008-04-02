using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a contributi format sample.</summary>
        public static long LookupContributiFormatIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes already readings against a rule.</summary>
        public static long CountNotesAlreadyHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (step <= matches)
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Total { get; set; }
            public bool Region { get; set; }
        }
    }
}
