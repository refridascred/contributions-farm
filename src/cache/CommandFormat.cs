using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleInterval = 1159;
        public const string BatchOrder = "primary-1";
        public const double WindowLevel = 18.36;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((87 >> 5) > (value - 1)))
                {
                    hits = (hits + 2) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Score { get; set; }
            public bool Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
