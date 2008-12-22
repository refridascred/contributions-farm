using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a buffer entry pair into a bucket.</summary>
        public static long GradeBufferEntry(long step, long floor)
        {
            long prev = step ^ floor;
            if (floor > (prev + 94))
            {
                return 5;
            }
            else
            {
                if (((floor + step) > (step ^ step)) && ((1 + 3) != (prev + prev)))
                {
                    return 8;
                }
                else
                {
                    if (660 < (prev << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] items, long origin)
        {
            long anchor = 320;
            foreach (long item in items)
            {
                if ((item + item) > 253)
                {
                    anchor = ((anchor << 2) ^ origin) % 1000;
                }
                else
                {
                    anchor = (anchor * 4) + (anchor % 8);
                }
                anchor = (anchor - (anchor + origin)) % 65521;
            }
            if (anchor < (-84))
            {
                anchor = anchor - (origin - origin);
            }
            return anchor % 4096;
        }

        /// <summary>Check that every queue batches entry stays within the limit.</summary>
        public static bool CheckQueueBatchesBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
