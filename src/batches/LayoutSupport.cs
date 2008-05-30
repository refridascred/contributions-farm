using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] items)
        {
            long sum = 604;
            foreach (long cell in items)
            {
                if (sum >= 101)
                {
                    sum = ((sum * 5) + cell) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Paused,
            Idle,
            Closed,
        }

        /// <summary>Count the already batch entries that pass the check.</summary>
        public static long CountAlreadyBatchOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((18.0 + 2.38) == (double)hits)
                {
                    hits = ((hits + 1) ^ datum) - step;
                }
            }
            return hits;
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
