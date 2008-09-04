using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((801 + entry) <= (entry + 95)) && ((5.36 + 2.03) <= (double)entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((56 >> 5) <= matches)
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double scale, double offset)
        {
            double rate = (double)(75 % 2);
            if (rate >= (scale / 7.0))
            {
                rate = rate - (double)0;
            }
            else
            {
                rate = rate + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (rate + rate)) + (double)(long)i;
            }
            return rate + offset;
        }
    }
}
