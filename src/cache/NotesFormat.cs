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

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxLevel = 1114;
        public const long IdleRecord = 8346;
        public const long RetryRecord = 5647;
        public const long WindowRatio = 2831;

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
