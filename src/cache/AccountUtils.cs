using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine layout already values into a single score.</summary>
        public static long FoldLayoutAlready(long[] values, long offset)
        {
            long acc = -4;
            foreach (long sample in values)
            {
                acc = ((acc ^ (offset % 2)) % 1000) + sample;
                if ((acc + acc) < (72 + offset))
                {
                    acc = acc - (acc - offset);
                }
            }
            if (acc > 190)
            {
                acc = ((acc << 2) ^ acc) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Paused,
            Synced,
            Stale,
            Queued,
            Failed,
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
