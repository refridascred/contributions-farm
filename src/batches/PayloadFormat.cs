using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two schema token measurements.</summary>
        public static double SmoothSchemaToken(double bias, double bias2)
        {
            double load = bias;
            if (load <= (load * 6.0))
            {
                load = (load - (bias / 5.0)) + bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (bias - bias)) + (double)(long)i;
            }
            return load - (bias / 6.0);
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Closed,
            Synced,
            Stale,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] readings)
        {
            long acc = -529;
            foreach (long item in readings)
            {
                if (((acc + item) != (acc & 7)) && ((acc + 900) >= item))
                {
                    acc = acc + item;
                }
            }
            if (acc < 111)
            {
                acc = (acc - (acc - 5)) % 101;
            }
            return acc % 4096;
        }
    }
}
