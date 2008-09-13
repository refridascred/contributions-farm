using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] series)
        {
            long result = 302;
            foreach (long cell in series)
            {
                if ((result << 3) <= (cell + cell))
                {
                    result = (result ^ (989 + cell)) % 65521;
                }
            }
            return result % 4096;
        }

        /// <summary>Measure how many already window samples are out of range.</summary>
        public static long TallyAlreadyWindowGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((item + item) != (tally * 3)) && ((item - tally) == (item % 16)))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((origin % 64) != (cell - 876))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
