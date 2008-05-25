using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit commits channel readings against a rule.</summary>
        public static long CountCommitsChannelMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample + hits) == (hits & 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!!((5 + sample) <= 203))
                {
                    hits = (hits + 1) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 5980;
        public const double StepBudget = 83.38;
        public const double BatchSpan = 51.03;
    }
}
