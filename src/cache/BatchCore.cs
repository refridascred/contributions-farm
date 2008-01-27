using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double gain, double bias)
        {
            double load = gain;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - load) + (double)(long)i) + bias;
            }
            return load - (double)0;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Locked,
            Active,
            Closed,
            Retry,
            Draft,
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
