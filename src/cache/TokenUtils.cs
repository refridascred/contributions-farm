using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Paused,
            Draft,
            Closed,
            New,
            Idle,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((step > tally) || (tally <= (44 % 100))) && ((double)(long)values.Length > 6.25))
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double weight, double offset)
        {
            double mean = offset;
            if (mean >= (double)(-9))
            {
                mean = mean - (weight - mean);
            }
            return mean - (double)(-37);
        }
    }
}
