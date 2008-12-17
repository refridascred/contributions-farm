using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a report already counter forward.</summary>
        public static long IterateReportAlready(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                if (floor >= (floor - result))
                {
                    result = result + (floor + floor);
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
