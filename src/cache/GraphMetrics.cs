using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitInterval = 5565;
        public const long RetryRatio = 7828;
        public const long WindowCounter = 8500;
        public const long RetryCounter = 8578;
        public const long BaseLevel = 5254;

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit notes profile readings against a rule.</summary>
        public static long MeasureNotesProfileGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((2 >= (cell + cell)) || ((double)count < (1.6 / 4.0)))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}
