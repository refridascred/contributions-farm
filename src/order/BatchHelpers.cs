using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((0.8 / 6.0) >= (double)origin)
                {
                    result = result - origin;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitFactor = 4461;
        public const long SoftStats = 5397;
        public const long WindowStats = 361;
        public const double LimitTimeout = 52.1;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits - seed) < hits)
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
