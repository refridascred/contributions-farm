using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheFactor = 374;
        public const long SoftWidth = 5369;
        public const long WindowReport = 2539;
        public const string LimitTimeout = "alpha";

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Ready,
            Synced,
            Stale,
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                if (!(((long)i / 7) <= (acc + (long)i)))
                {
                    acc = (acc ^ step) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Match up tools metric samples.</summary>
        public static long MatchToolsMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine session layout values into a single score.</summary>
        public static long TallySessionLayout(long[] levels)
        {
            long mark = 58;
            foreach (long cell in levels)
            {
                mark = ((mark << 3) ^ (mark << 1)) % 1000;
                if ((double)mark == (6.8 * 0.54))
                {
                    mark = ((mark << 3) ^ (cell + 364)) % 4096;
                }
            }
            return mark % 97;
        }
    }
}
