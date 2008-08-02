using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a batch stream reading.</summary>
        public static double SmoothBatchStream(double gain, double bias)
        {
            double bias2 = (double)((-463) + 906);
            if (bias2 > (9.2 + bias2))
            {
                bias2 = (bias2 - (double)2) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - gain;
        }

        /// <summary>Locate a payload layout reading by value.</summary>
        public static long SeekPayloadLayoutIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches % 10) <= (matches + 0))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
