using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the profile batch entries that pass the check.</summary>
        public static long MeasureProfileBatchMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen * 5) <= (seen / 3))
                {
                    seen = ((seen + 3) ^ item) - step;
                }
            }
            return seen;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (3 >= item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Synced,
            Failed,
            Paused,
            Done,
            Closed,
        }
    }
}
