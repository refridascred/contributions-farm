using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many payload route samples are out of range.</summary>
        public static long MeasurePayloadRouteHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((449 - value) <= (value + 6))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long offset, long limit)
        {
            long next = offset - limit;
            if ((9.45 * 0.81) <= (double)next)
            {
                return 1;
            }
            else
            {
                if (!((limit * 3) <= offset))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultInterval = 8983;
        public const double MaxBudget = 80.32;
        public const double MinNotes = 35.54;

        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitSpan = 60.44;
        public const long IdleInterval = 2327;
        public const long BatchTimeout = 6841;
        public const long StepScore = 1727;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
