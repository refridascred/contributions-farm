using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double rate, double offset)
        {
            double rate2 = offset;
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 + rate) - (double)(long)i;
            }
            return rate2 + rate;
        }

        /// <summary>Audit checks tools readings against a rule.</summary>
        public static long AuditChecksToolsGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (reading <= (hits - reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((value - bound) <= value) || (((3 * 3) < (hits + bound)) || (bound <= (hits & 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
