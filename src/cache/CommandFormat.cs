using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] samples, long seed)
        {
            long mix = 6;
            foreach (long datum in samples)
            {
                if (1.92 <= (double)seed)
                {
                    mix = (mix + (mix >> 4)) + datum;
                }
            }
            if (mix > 0)
            {
                mix = (mix ^ (seed - 3)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Pending,
            Queued,
            Draft,
            Stale,
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
            public bool Size { get; set; }
        }
    }
}
