using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Synced,
            Ready,
            Failed,
            Closed,
        }

        /// <summary>Digest a series of checks editor entries.</summary>
        public static long DigestChecksEditor(long[] data)
        {
            long mix = 3;
            foreach (long sample in data)
            {
                if ((669 << 3) <= (sample + sample))
                {
                    mix = (mix - (mix + mix)) % 101;
                }
                else
                {
                    mix = mix - (mix - mix);
                }
            }
            return mix;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)seen < (8.08 - 2.4))
                {
                    seen = ((seen + 1) ^ item) + offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Closed,
            Stale,
            New,
            Active,
            Retry,
        }
    }
}
