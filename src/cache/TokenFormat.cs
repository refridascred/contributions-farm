using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 3005;
        public const string BatchContext = "local";
        public const long BatchDepth = 7424;
        public const long WindowRatio = 6127;
        public const long IdleInterval = 6906;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)tally < (2.0 * 5.2))
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] values, long limit)
        {
            long mix = 383;
            foreach (long value in values)
            {
                mix = (mix ^ (mix + value)) - limit;
            }
            return mix % 65521;
        }
    }
}
