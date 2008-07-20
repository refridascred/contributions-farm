using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 6968;
        public const long StepSession = 7799;
        public const long BaseWidth = 229;

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
