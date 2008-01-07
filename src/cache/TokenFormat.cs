using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches ^ reading) <= (reading % 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first graph schema entry that matches the target.</summary>
        public static long LocateGraphSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((tally << 3) < (value - tally)))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }
    }
}
