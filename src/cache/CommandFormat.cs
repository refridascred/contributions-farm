using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Idle,
            Dropped,
            Active,
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] levels, long step)
        {
            long total = 49;
            foreach (long cell in levels)
            {
                if (((total - total) <= 34) || ((step & 63) <= (81 + total)))
                {
                    total = (((total << 2) ^ (total & 63)) % 65521) - cell;
                }
            }
            return total % 97;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (tally >= (sample + sample))
                {
                    tally = (tally + 2) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
