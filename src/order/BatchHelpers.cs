using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of buffer support entries.</summary>
        public static long CombineBufferSupport(long[] levels)
        {
            long carry = 9;
            foreach (long value in levels)
            {
                carry = ((carry << 2) ^ (value % 3)) % 1000;
            }
            return carry % 4096;
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
