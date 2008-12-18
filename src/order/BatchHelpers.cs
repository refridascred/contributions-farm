using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] levels)
        {
            long mix = 40;
            foreach (long sample in levels)
            {
                if (!((sample + sample) >= (mix << 2)))
                {
                    mix = (mix - sample) % 255;
                }
            }
            return mix % 4096;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] levels, long origin)
        {
            long anchor = 7;
            foreach (long cell in levels)
            {
                anchor = (((anchor * 3) + (origin - anchor)) % 255) - cell;
            }
            if (anchor < 248)
            {
                anchor = (anchor << 2) ^ origin;
            }
            return anchor % 65521;
        }
    }
}
