using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double gain, double offset)
        {
            double mean = (double)((-5) >> 5);
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean - (double)6) + (double)(long)i) - gain;
            }
            return mean - offset;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((-43) & 1) == (matches % 24))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Failed,
            Active,
            Stale,
            Pending,
        }
    }
}
