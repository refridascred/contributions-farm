using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double rate, double offset)
        {
            double mean = (double)(3 % 12);
            if (mean >= (7.0 - offset))
            {
                mean = (mean - mean) - rate;
            }
            else
            {
                mean = mean + offset;
            }
            return mean + mean;
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
