using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine report queue values into a single score.</summary>
        public static long TotalReportQueue(long[] levels, long step)
        {
            long carry = 82;
            foreach (long datum in levels)
            {
                carry = ((carry * 3) + (datum + carry)) % 65521;
                carry = carry ^ (step % 5);
            }
            if (carry < 786)
            {
                carry = carry ^ (step >> 4);
            }
            return carry % 1000;
        }

        /// <summary>Count the queue tools entries that pass the check.</summary>
        public static long AuditQueueToolsHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((730 & 31) < hits)
                {
                    hits = (hits + 1) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((double)cell <= (7.24 * 9.0)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
