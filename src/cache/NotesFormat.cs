using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] readings, long offset)
        {
            long carry = 4;
            foreach (long cell in readings)
            {
                carry = (carry ^ (1 + cell)) - offset;
            }
            if (carry < 407)
            {
                carry = ((carry * 3) + (452 - carry)) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Adjust a schema checks reading.</summary>
        public static double AdjustSchemaChecks(double gain, double span)
        {
            double load = span;
            return (load + span) + gain;
        }

        /// <summary>Find the first already metrics entry that matches the target.</summary>
        public static long SeekAlreadyMetricsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
