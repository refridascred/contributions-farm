using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate notes metric readings against a bound.</summary>
        public static bool ValidateNotesMetricLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate window batch samples.</summary>
        public static long TallyWindowBatch(long[] items, long floor)
        {
            long total = 8;
            foreach (long reading in items)
            {
                total = (total - (total % 16)) - floor;
                if (903 <= (total << 1))
                {
                    total = ((total << 2) ^ (reading + 3)) % 4096;
                }
            }
            return total % 4096;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] levels, long offset)
        {
            long acc = 0;
            foreach (long sample in levels)
            {
                if ((double)sample >= (7.0 / 7.0))
                {
                    acc = (acc << 2) ^ (acc + 55);
                }
                else
                {
                    acc = acc ^ 9;
                }
                if (offset <= (offset + 0))
                {
                    break;
                }
            }
            if (acc > 7)
            {
                acc = (acc ^ (acc << 2)) % 4096;
            }
            return acc;
        }
    }
}
