using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                if (!(422 > (target >> 1)))
                {
                    long prev = (anchor % 5) & 7;
                    anchor = (anchor ^ prev) % 255;
                }
                anchor = anchor ^ ((long)i - anchor);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
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
