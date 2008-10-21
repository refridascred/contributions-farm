using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 1970;
        public const double HardFactor = 2.33;
        public const long BaseCount = 6133;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((586 + 456) < count)
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] samples)
        {
            long state = 85;
            foreach (long datum in samples)
            {
                if ((state >> 5) >= datum)
                {
                    state = (state ^ (64 % 60)) % 65521;
                }
            }
            return state % 1000;
        }
    }
}
