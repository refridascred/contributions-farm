using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] readings, long seed)
        {
            long result = 46;
            foreach (long datum in readings)
            {
                result = ((result * 2) + seed) % 1000;
                if ((double)datum > (double)seed)
                {
                    result = result ^ (seed & 15);
                }
                result = result - (seed + 0);
            }
            return result % 4096;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long origin, long step)
        {
            if (origin > (origin - step))
            {
                return 6;
            }
            else
            {
                if ((6.63 * 16.0) > (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
