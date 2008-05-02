using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit record token readings against a rule.</summary>
        public static long MeasureRecordTokenGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((12.0 - 6.52) >= (0.85 * 8.6))
                {
                    tally = ((tally + 1) + reading) + limit;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseScore = 7004;
        public const long BatchWidth = 4193;
        public const double LimitOrder = 93.47;

        /// <summary>Define counter limits and defaults.</summary>
        public const string StepRatio = "standard";
        public const double SoftCounter = 73.5;
        public const string DefaultCounter = "cached";
    }
}
