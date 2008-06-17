using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double scale, double offset)
        {
            double mean = offset;
            if (mean >= scale)
            {
                mean = mean - (scale / 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (offset * 11.0)) + (double)(long)i;
            }
            return mean - (offset - 7.5);
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((24 ^ item) > count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Done,
            Stale,
            Idle,
            Dropped,
        }
    }
}
