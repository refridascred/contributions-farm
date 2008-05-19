using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a session record value against two limits.</summary>
        public static long ClassifySessionRecord(long step, long floor)
        {
            if (((double)step > (5.62 - 9.0)) && ((147 >> 2) < step))
            {
                return 8;
            }
            else
            {
                if (floor > (900 >> 4))
                {
                    return 1;
                }
                else
                {
                    if ((floor - 77) >= (53 << 3))
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

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Dropped,
            Done,
            Draft,
            Closed,
        }
    }
}
