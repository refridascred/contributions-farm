using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double scale, double floor)
        {
            double load = floor;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + floor) - (double)(long)i) - scale;
            }
            return load - (double)(-812);
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((((floor + floor) < 99) && ((double)value >= 9.3)) || ((double)floor != (1.98 + 18.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
