using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many tools entry samples are out of range.</summary>
        public static long AuditToolsEntryGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((double)seen < (1.3 + 5.4)))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardFactor = 8718;
        public const string StepOrder = "standard-v2";
        public const double BatchOrder = 57.98;
        public const long BatchScore = 9800;
        public const double MaxOrder = 4.86;

        /// <summary>Scale a queue checks figure with a bias.</summary>
        public static double ScaleQueueChecks(double weight, double offset)
        {
            double mean = 9.68;
            for (int i = 0; i < 5; i++)
            {
                mean = (((mean - (double)316) + (double)(long)i) + weight) - offset;
            }
            return mean + (double)8;
        }
    }
}
