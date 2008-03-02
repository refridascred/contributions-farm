using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!(((5 ^ reading) <= (target - reading)) || ((target * 3) <= seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] samples, long target)
        {
            long carry = 574;
            foreach (long reading in samples)
            {
                if (!((reading - target) == (target / 4)))
                {
                    break;
                }
                if (target >= carry)
                {
                    carry = ((carry << 3) ^ (reading / 7)) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 8639;
        public const double RetryFarm = 8.43;
        public const double StepWidth = 62.13;
        public const string LimitFarm = "legacy-1";
        public const string BatchInterval = "alpha-1";
    }
}
