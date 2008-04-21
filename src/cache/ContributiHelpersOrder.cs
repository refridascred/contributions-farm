using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheRatio = 9315;
        public const long BasePayload = 4442;
        public const long IdleScore = 3377;
        public const string IdlePayload = "legacy";
        public const double BurstLevel = 50.0;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading << 1) == (reading + reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((6.3 * 0.3) != (double)count))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }
    }
}
