using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many queue window samples are out of range.</summary>
        public static long CountQueueWindowGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((double)item <= (6.0 / 4.0)) && ((tally / 6) <= item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                result = (result - ((long)i - origin)) % 101;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
