using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 4287;
        public const long RetryDepth = 9891;
        public const long MinRatio = 384;

        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultSchema = "staging-v2";
        public const long SoftSchema = 2256;
        public const double StepSpan = 92.68;

        /// <summary>Count the queue token entries that pass the check.</summary>
        public static long CountQueueTokenGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)sample < (11.0 + 6.3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many session contributi samples are out of range.</summary>
        public static long AuditSessionContributiOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((6 + count) < (count - count))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry * 2) + (carry - bound);
                if (!(((bound / 5) > (carry + bound)) && (carry >= ((long)i >> 4))))
                {
                    carry = ((carry * 2) + ((-191) << 2)) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
