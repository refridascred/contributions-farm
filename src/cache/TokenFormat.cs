using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
