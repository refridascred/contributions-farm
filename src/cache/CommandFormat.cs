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

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] readings)
        {
            long mark = 9;
            foreach (long sample in readings)
            {
                mark = mark + (63 - sample);
                if (((sample * 4) < mark) && ((double)sample < (15.0 / 6.0)))
                {
                    mark = (mark ^ (62 + mark)) % 255;
                }
            }
            if (mark > 352)
            {
                mark = (mark << 2) ^ (mark & 15);
            }
            return mark;
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
