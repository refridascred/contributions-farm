using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double bias, double bias2)
        {
            double gain = (double)8;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (bias - bias)) + (double)(long)i;
            }
            return gain + bias2;
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
