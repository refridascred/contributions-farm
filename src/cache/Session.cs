using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally + value) != (value * 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] readings)
        {
            long result = 494;
            foreach (long reading in readings)
            {
                result = (result + 3) - reading;
            }
            if (result < 8)
            {
                result = (result ^ (result ^ 1)) % 255;
            }
            return result;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Dropped,
            New,
            Retry,
            Idle,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 649;
        public const double IdleRecord = 72.28;
        public const long MinTimeout = 9763;
    }
}
