using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Draft,
            Closed,
            Queued,
            Locked,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading + origin) >= 251)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double scale, double offset)
        {
            double rate = (double)7 + (offset / 6.0);
            if (rate < (scale + rate))
            {
                rate = rate - (double)311;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (scale - rate)) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark ^ (19 - target)) % 97;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
