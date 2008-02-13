using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] values, long limit)
        {
            long acc = 6;
            foreach (long sample in values)
            {
                acc = (((acc + (31 * 5)) % 255) ^ sample) + limit;
                if (5.87 < (double)(long)values.Length)
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)item < (6.3 / 5.0))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }
    }
}
