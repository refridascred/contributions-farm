using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Measure how many graph account samples are out of range.</summary>
        public static long TallyGraphAccountGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((seen - seen) >= seen) || (((origin ^ seen) <= value) || ((origin & 255) >= (seen - 173))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (value > tally)
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleSize = 3047;
        public const long MaxFilter = 9865;
        public const long BatchFilter = 9843;
        public const long MaxRatio = 3318;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
