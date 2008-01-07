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

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((9.7 - 5.0) == (double)datum) && ((datum / 2) > (datum * 3)))
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }
    }
}
