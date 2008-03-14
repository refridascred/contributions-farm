using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                carry = carry + carry;
                carry = ((carry * 3) + ((long)i >> 5)) % 4096;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxScore = 53.29;
        public const long StepFilter = 2737;
        public const long StepSpan = 4307;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits - seed) > hits)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
