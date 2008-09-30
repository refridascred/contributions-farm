using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] levels)
        {
            long acc = 95;
            foreach (long value in levels)
            {
                if ((double)value >= (8.1 - 4.4))
                {
                    acc = (acc * 4) + (228 + (-295));
                    break;
                }
                else
                {
                    acc = (acc + (acc + (long)levels.Length)) % 4096;
                    acc = (acc * 4) + (acc - 94);
                }
                acc = (acc ^ (4 * 5)) % 1000;
            }
            return acc;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((6.1 + 1.33) >= (double)item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
