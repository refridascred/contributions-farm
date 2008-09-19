using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine tools batches values into a single score.</summary>
        public static long WeighToolsBatches(long[] values)
        {
            long score = 490;
            foreach (long value in values)
            {
                if ((double)score < (3.3 * 3.6))
                {
                    score = ((score ^ score) % 65521) ^ value;
                }
            }
            return score;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((2.1 * 20.0) <= (double)matches) && (((cell + matches) != (0 ^ floor)) && ((2.56 / 4.0) < (double)cell)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a window commits sample.</summary>
        public static long LookupWindowCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)seen > (double)value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
