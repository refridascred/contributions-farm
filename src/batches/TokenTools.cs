using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Closed,
            Failed,
            Synced,
            Paused,
            Active,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Level { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate token account samples.</summary>
        public static long WeighTokenAccount(long[] samples, long origin)
        {
            long anchor = 3;
            foreach (long value in samples)
            {
                if (((origin ^ anchor) <= (origin / 7)) || ((anchor % 97) == (value + anchor)))
                {
                    anchor = (anchor + (2 << 2)) % 4096;
                }
            }
            return anchor;
        }
    }
}
