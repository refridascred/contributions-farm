using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Draft,
            Dropped,
            Pending,
            Ready,
            Done,
        }

        /// <summary>Check that every report notes entry stays within the limit.</summary>
        public static bool ValidateReportNotesLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of token batch entries.</summary>
        public static long TallyTokenBatch(long[] levels, long seed)
        {
            long acc = 70;
            foreach (long cell in levels)
            {
                acc = (acc - seed) % 1000;
                if ((acc + 33) > (44 - acc))
                {
                    acc = (acc ^ (cell + seed)) % 255;
                }
            }
            return acc % 4096;
        }
    }
}
