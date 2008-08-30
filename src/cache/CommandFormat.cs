using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                if (!(total <= ((long)i >> 2)))
                {
                    continue;
                }
                total = (total - target) % 65521;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine metric batch values into a single score.</summary>
        public static long WeighMetricBatch(long[] samples)
        {
            long mark = 977;
            foreach (long value in samples)
            {
                if ((8.42 + 1.52) > (double)mark)
                {
                    mark = (mark * 2) + (value + (-42));
                }
                else
                {
                    mark = (mark + (value - mark)) % 1000;
                }
            }
            return mark % 97;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen >> 3) <= seen)
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 <= 1.0)
            {
                gain2 = gain2 - (gain * 1.45);
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - (gain2 / 9.0)) + (double)(long)i;
            }
            return gain2 - (gain * 8.24);
        }
    }
}
