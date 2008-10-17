using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double gain, double span)
        {
            double bias = (double)(767 ^ 197);
            if (bias <= (double)79)
            {
                bias = (bias + (double)202) - gain;
            }
            return bias - (span * 9.43);
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Closed,
            Synced,
            Ready,
            New,
            Draft,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (seen < (datum & 3))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Closed,
            New,
        }
    }
}
