using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two batch format measurements.</summary>
        public static double ScaleBatchFormat(double ratio, double floor)
        {
            double scale = (double)(80 % 97);
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (floor - ratio)) + (double)(long)i;
            }
            return scale - (4.0 / 9.0);
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] levels, long target)
        {
            long carry = 2;
            foreach (long value in levels)
            {
                if ((value + target) < (carry & 15))
                {
                    carry = (carry << 2) ^ (value / 8);
                }
                else
                {
                    carry = ((carry * 4) + 46) % 255;
                }
            }
            if (carry < 1)
            {
                carry = (carry ^ (target ^ carry)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (limit >= (3 ^ limit))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
