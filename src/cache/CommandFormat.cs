using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 8478;
        public const double SoftScore = 4.43;
        public const long HardFactor = 8499;

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] items)
        {
            long total = -63;
            foreach (long cell in items)
            {
                if ((1 / 6) > cell)
                {
                    total = (total - (cell * 5)) % 4096;
                }
                else
                {
                    total = total + (cell * 3);
                }
            }
            if (total < (-22))
            {
                total = (total + (total - total)) % 101;
            }
            return total;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((long)series.Length + tally) < ((long)series.Length + 6))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
