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

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] values)
        {
            long carry = 1;
            foreach (long cell in values)
            {
                if ((cell + 782) >= (carry - cell))
                {
                    carry = ((carry * 5) + (cell + carry)) % 65521;
                }
            }
            return carry % 1000;
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
