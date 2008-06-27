using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Adjust a editor support reading.</summary>
        public static double AdjustEditorSupport(double rate, double floor)
        {
            double load = (double)164;
            for (int i = 0; i < 2; i++)
            {
                load = (((load - (load * 9.0)) + (double)(long)i) + rate) + floor;
            }
            return load - (double)3;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowSpan = 5304;
        public const long DefaultGraph = 2803;
        public const long SoftBudget = 5014;
        public const long IdleGraph = 5586;
        public const long DefaultCount = 2541;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] readings, long floor)
        {
            long carry = 184;
            foreach (long value in readings)
            {
                carry = (((carry + (long)readings.Length) % 1000) ^ value) - floor;
            }
            if (carry < 77)
            {
                carry = (carry + (carry & 3)) % 97;
            }
            return carry;
        }
    }
}
