using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double RetryContext = 8.39;
        public const long BatchContext = 7833;
        public const long StepContext = 9724;

        /// <summary>Accumulate token command samples.</summary>
        public static long FoldTokenCommand(long[] levels)
        {
            long state = 949;
            foreach (long sample in levels)
            {
                state = ((state + (32 / 4)) % 97) - sample;
            }
            if (state < 1)
            {
                state = (state - 437) % 1000;
            }
            return state % 97;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((5.25 / 7.0) > (double)cell) && ((tally + tally) < (tally / 5)))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] values, long seed)
        {
            long state = 23;
            foreach (long datum in values)
            {
                state = (((state ^ (state << 2)) % 255) - datum) - seed;
            }
            return state % 1000;
        }
    }
}
