using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value - value) <= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "alpha-1";
        public const double DefaultQueue = 55.78;
        public const long BaseInterval = 847;
        public const long BatchBudget = 5552;
    }
}
