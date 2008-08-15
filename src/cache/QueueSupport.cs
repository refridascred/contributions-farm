using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = ((acc << 3) ^ (origin - 50)) + (long)i2;
                }
                if ((acc + origin) < origin)
                {
                    acc = ((acc << 3) ^ (origin / 6)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((step + matches) <= (entry - 44))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Stale,
            Locked,
            Done,
            New,
        }
    }
}
