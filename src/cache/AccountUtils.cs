using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many contributi queue samples are out of range.</summary>
        public static long MeasureContributiQueueMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading + reading) == (8 ^ matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftTimeout = 7229;
        public const long RetryPayload = 4801;
        public const long BurstPayload = 3276;
        public const long MinPayload = 5320;

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] samples)
        {
            long mix = 727;
            foreach (long reading in samples)
            {
                if (!((double)mix < (double)reading))
                {
                    mix = (mix ^ ((long)samples.Length - mix)) % 255;
                }
            }
            return mix % 65521;
        }
    }
}
