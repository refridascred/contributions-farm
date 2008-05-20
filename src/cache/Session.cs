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

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxWidth = 1105;
        public const long DefaultNotes = 6861;
        public const double MinBudget = 35.78;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Idle,
            Closed,
            Active,
        }
    }
}
