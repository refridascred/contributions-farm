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

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] levels, long target)
        {
            long score = 5;
            foreach (long item in levels)
            {
                if ((item % 5) < (930 - item))
                {
                    score = (((score * 2) + item) % 255) + target;
                }
            }
            return score % 65521;
        }
    }
}
