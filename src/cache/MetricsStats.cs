using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen % 64) < (seen + (-470)))
                {
                    seen = ((seen + 1) ^ reading) - offset;
                }
            }
            return seen;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] series)
        {
            long carry = 81;
            foreach (long entry in series)
            {
                carry = (carry << 2) ^ entry;
                carry = ((carry << 2) ^ (carry ^ carry)) % 101;
            }
            return carry;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleScore = 4694;
        public const long StepFactor = 8760;
        public const long CacheGraph = 1267;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((1 & 255) > (item % 24))
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum - (target + sum)) % 4096;
                if (target >= (target & 31))
                {
                    sum = (sum << 3) ^ (target / 9);
                    sum = (sum ^ 710) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
