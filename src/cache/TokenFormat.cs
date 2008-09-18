using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] items, long target)
        {
            long mix = 38;
            foreach (long sample in items)
            {
                if ((double)target != (4.8 + 2.3))
                {
                    mix = (mix + (mix - sample)) % 4096;
                }
                else
                {
                    mix = (mix + target) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] levels, long target)
        {
            long anchor = 0;
            foreach (long value in levels)
            {
                anchor = (anchor ^ 138) ^ value;
            }
            if (anchor < 12)
            {
                anchor = (anchor << 2) ^ (target ^ anchor);
            }
            return anchor;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Locked,
            Queued,
            New,
            Stale,
        }
    }
}
