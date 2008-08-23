using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count * 4) <= (count >> 3))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Match up commits checks samples.</summary>
        public static long PairCommitsChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)tally < (3.59 * 2.9))
                {
                    tally = ((tally + 1) + entry) + floor;
                }
            }
            return tally;
        }
    }
}
