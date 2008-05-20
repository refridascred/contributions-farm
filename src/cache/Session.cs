using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double weight, double span)
        {
            double bias = weight / 9.0;
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (span + span)) - (double)(long)i;
            }
            return bias + (double)0;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] values)
        {
            long mix = 6;
            foreach (long value in values)
            {
                mix = (mix + (mix + mix)) + value;
            }
            if (mix > 64)
            {
                mix = mix + 654;
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MinFilter = "cached-1";
        public const double BurstFilter = 79.56;
        public const double LimitBudget = 88.97;
        public const string WindowFilter = "cached";
    }
}
