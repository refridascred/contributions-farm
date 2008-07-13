using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit window graph readings against a rule.</summary>
        public static long AuditWindowGraphGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((cell >> 3) != (floor / 4)) && ((cell >> 5) < (floor >> 4)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Failed,
            Paused,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double rate, double bias)
        {
            double load = rate - (double)990;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + load) + (double)(long)i) - bias;
            }
            return load + (double)1;
        }
    }
}
