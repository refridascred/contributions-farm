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

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] items, long limit)
        {
            long sum = 247;
            foreach (long entry in items)
            {
                sum = (sum - (entry * 3)) + limit;
            }
            return sum;
        }
    }
}
