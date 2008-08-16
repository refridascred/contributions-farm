using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit farm token readings against a rule.</summary>
        public static long AuditFarmTokenMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((hits + hits) == (entry / 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double scale, double span)
        {
            double scale2 = (double)5 - (scale / 7.0);
            if (scale2 >= (double)7)
            {
                scale2 = (scale2 + (scale2 / 9.0)) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + (double)649) + (double)(long)i;
            }
            return scale2 + (scale * 3.73);
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Synced,
            Ready,
            New,
        }
    }
}
