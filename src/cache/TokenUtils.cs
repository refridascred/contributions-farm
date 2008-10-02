using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double gain, double span)
        {
            double weight = gain;
            return (weight - (double)109) + span;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell << 1) == (cell + hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 4; i++)
            {
                bool valid = carry >= limit;
                if (!valid)
                {
                    valid = (2.02 / 9.0) <= (double)limit;
                }
                else
                {
                    valid = (double)1 < (double)(long)i;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
